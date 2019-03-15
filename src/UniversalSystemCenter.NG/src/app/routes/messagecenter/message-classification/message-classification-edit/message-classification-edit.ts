import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { MessageClassificationService } from '../message-classification.service';
import { ServiceApplicationService } from 'app/routes/systems/application/application.service';

@Component({
  templateUrl: 'message-classification-edit.html',
  providers: [ServiceApplicationService],
})
export class MessageClassificationEdit implements OnInit {
  entity: any;

  /**
   * 0 新增  ， 1 编辑
   */
  action = 0;

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
    public msgSrv: NzMessageService,
    public _MessageClassificationService: MessageClassificationService,
    public _serviceApplicationService: ServiceApplicationService,
  ) {}

  ngOnInit() {
    this.loadAppOption();
    this.action = this.entity.id ? 1 : 0;
    this.params.id = this.entity.id;

    if (this.action == 1) {
      this._MessageClassificationService
        .getById(this.entity.id)
        .subscribe((res: any) => {
          this.params = res;
        });
    }
  }

  loadAppOption() {
    this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
      this.AppTypeoption = res.data;
    });
  }

  save() {
    let resut;
    if (this.action == 0) {
      resut = this._MessageClassificationService.add(this.params);
    } else {
      resut = this._MessageClassificationService.edit(this.params);
    }
    resut.subscribe(res => {
      if (res.result == 0) {
        this.msgSrv.success(res.message);
        this.close(true);
      } else {
        this.msgSrv.error(res.message);
      }
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
