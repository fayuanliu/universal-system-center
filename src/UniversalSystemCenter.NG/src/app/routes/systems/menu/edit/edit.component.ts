import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { MenuService } from '../menu.servcie';
import { ApplicationService } from '../../application/application.service';

@Component({
  templateUrl: './edit.component.html',
})
export class MenuEditComponent implements OnInit {
  /**
   * 由其它页面传过来的参数
   */
  qModel;
  /**
   * 0 添加 ，  1 编辑
   */
  action: ActionEnum = ActionEnum.ADD;

  app_option: any[];
  params = {
    id: null,
    name: null,
    isGroup: false,
    link: '',
    icon: '',
    code: 'code',
    isOpen: false,
    parentId: null,
    enabled: true,
    sortId: 0,
    appId: null,
  };
  constructor(
    private subject: NzModalRef,
    public message: NzMessageService,
    public service: MenuService,
    public ApplicationService: ApplicationService,
  ) {}

  ngOnInit() {
    this.loadAppOption();
    this.action = this.qModel.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.qModel.id;
    this.params.isGroup = this.qModel.parentId ? false : true;
    this.params.parentId = this.qModel.parentId;
    if (this.action == ActionEnum.EDIT) {
      this.service.getById(this.params.id).subscribe((res: any) => {
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
      resut = this.service.add(this.params);
    } else {
      resut = this.service.edit(this.params);
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
