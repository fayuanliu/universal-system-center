import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ResourceService } from '../resource.service';
import { ApplicationService } from '../../application/application.service';

@Component({
  templateUrl: 'edit.component.html',
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
  action: ActionEnum = ActionEnum.ADD;

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
    public message: NzMessageService,
    public servcie: ResourceService,
    public ApplicationService: ApplicationService,
  ) {}
  ngOnInit() {
    this.loadAppOption();

    this.action = this.entity.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.entity.id;
    this.params.parentId = this.entity.parentId;
    this.params.appId = this.appId;

    if (this.action == ActionEnum.EDIT) {
      this.servcie.getById(this.entity.id).subscribe((res: any) => {
        this.params = res;
      });
    }
  }

  loadAppOption() {
    this.ApplicationService.getAppOptionList().subscribe((res: any) => {
      this.app_option = res.data;
    });
  }

  save() {
    let resut;
    if (this.action == ActionEnum.ADD) {
      resut = this.servcie.add(this.params);
    } else {
      resut = this.servcie.edit(this.params);
    }
    resut.subscribe(res => {
      if (res.result == 0) {
        this.message.success(res.message);
        this.close(true);
      } else {
        this.message.error(res.message);
      }
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
