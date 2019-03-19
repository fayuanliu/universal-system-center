import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { RoleService } from '../role.service';
import { ApplicationService } from '../../application/application.service';
import { RoleModule } from 'app/app.global';

@Component({
  templateUrl: 'edit.component.html',
})
export class RoleEditComponent implements OnInit {
  id: string;

  /**
   * 0 添加 ，  1 编辑
   */
  action: ActionEnum = ActionEnum.ADD;

  params = {
    id: null,
    name: null,
    values: null,
    icon: null,
    isEnabled: true,
    sortId: 0,
    appId: null,
  };
  app_option: any[];
  _RoleModule: string = RoleModule; //商品主图上传模块

  constructor(
    private subject: NzModalRef,
    public message: NzMessageService,
    public servcie: RoleService,
    public ApplicationService: ApplicationService,
  ) {}

  ngOnInit() {
    this.action = this.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.id;
    this.loadAppOption();
    if (this.action == ActionEnum.EDIT) {
      this.servcie.getById(this.params.id).subscribe((res: any) => {
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
