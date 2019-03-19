import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { MessageClassificationService } from '../message-classification.service';
import { ApplicationService } from 'app/routes/systems/application/application.service';

@Component({
  templateUrl: 'message-classification-edit.html',
})
export class MessageClassificationEdit implements OnInit {
  entity: any;

  /**
   * 0 新增  ， 1 编辑
   */
  action:ActionEnum = ActionEnum.ADD;

  params = {
    id: null,
    name: null,
    sortId: 0,
    isEnabled: true,
    type: 0,
    appType: null,
  };

  TypeOptions = [
    { value: 0, label: '通知' },
    { value: 1, label: '消息' },
    { value: 2, label: '待办' },
  ];
  AppTypeoption = [];
  constructor(
    private subject: NzModalRef,
    public message: NzMessageService,
    public service: MessageClassificationService,
    public ApplicationService: ApplicationService,
  ) {}

  ngOnInit() {
    this.loadAppOption();
    this.action = this.entity.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.entity.id;

    if (this.action == ActionEnum.EDIT) {
      this.service
        .getById(this.entity.id)
        .subscribe((res: any) => {
          this.params = res;
        });
    }
  }

  loadAppOption() {
    this.ApplicationService.getAppOptionList().subscribe((res: any) => {
      this.AppTypeoption = res.data;
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
