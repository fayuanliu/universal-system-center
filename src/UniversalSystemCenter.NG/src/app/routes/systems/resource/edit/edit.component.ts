import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ResourceService } from '../resource.service';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
  selector: 'app-resource-edit',
  templateUrl: 'edit.component.html',
  providers: [ResourceService, ServiceApplicationService],
})
export class ResourceEditComponent implements OnInit {
  /**
   * 由其它页面传过来的参数
   */
  entity: any;
  appId: any;

  /**
   * 0 添加 ，  1 编辑
   */
  action = 0;

  params = {
    id: null,
    uri: null,
    name: null,
    type: 0,
    note: null,
    parentIdStr: null,
    isEnabled: true,
    sortId: 0,
    parentId: null,
    appId: null,
  };

  cascader: any[];
  app_option: any[];

  constructor(
    private subject: NzModalRef,
    public msgSrv: NzMessageService,
    public servcie: ResourceService,
    public _serviceApplicationService: ServiceApplicationService,
  ) {}
  ngOnInit() {
    this.loadAppOption();
    
    this.action = this.entity.id ? 1 : 0;
    this.params.id = this.entity.id;
    this.params.parentId = this.entity.parentId;
    this.params.appId = this.appId;

    if (this.action == 1) {
      this.servcie.getById(this.entity.id).subscribe((res: any) => {
        this.params = res;
      });
    }
  }

  loadAppOption() {
    this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
      this.app_option = res.data;
    });
  }

  save() {
    let resut;
    if (this.action == 0) {
      resut = this.servcie.add(this.params);
    } else {
      resut = this.servcie.edit(this.params);
    }
    resut.subscribe(res => {
      this.msgSrv.success(res.message);
      if (res.result == 0) {
        this.close(true);
      }
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
