import { NzMessageService } from 'ng-zorro-antd';
import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { ModalHelper } from '@delon/theme';
import { MessageClassificationService } from './message-classification.service';
import { MessageClassificationEdit } from './message-classification-edit/message-classification-edit';
import { MessageTemplateDetail } from './messageTemplate/messageTemplatedetail';

@Component({
  templateUrl: './message-classification-list.html',
})

/**
 * 消息分类列表
 */
export class MessageClassificationList implements OnInit {
  page = new Page({
    name: null,
  });

  constructor(
    public _MessageClassificationService: MessageClassificationService,
    private _ModalHelper: ModalHelper,
    private message: NzMessageService,
  ) {}

  ngOnInit() {
    this.load(true);
  }

  load(reset = false) {
    if (reset) {
      this.page.reset();
    }
    this._MessageClassificationService
      .getList(this.page)
      .subscribe((data: any) => {
        this.page.page = data.page;
        this.page.totalCount = data.totalCount;
        this.page.pageSize = data.pageSize;
        this.page.data = data.data;
      });
  }

  addOrEdit(params) {
    this._ModalHelper
      .static(MessageClassificationEdit, { entity: params })
      .subscribe(res => {
        if (res) {
          this.load(true);
        }
      });
  }

  setTemplate(entity) {
    this._ModalHelper
      .static(MessageTemplateDetail, {
        classificationid: entity.id,
        classificationName: entity.name,
      })
      .subscribe(res => {});
  }

  del() {
    this._MessageClassificationService
      .delete(this.page.selectedRows.join(','))
      .subscribe((res: any) => {
        if (res.result == 0) {
          this.message.success(res.message);
          this.load(true);
        } else {
          this.message.error(res.message);
        }
      });
  }
}
