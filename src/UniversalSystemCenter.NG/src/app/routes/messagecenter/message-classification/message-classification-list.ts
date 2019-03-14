
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
    page = new Page();

    constructor(
        private _MessageClassificationService: MessageClassificationService,
        private _ModalHelper: ModalHelper,
        private _NzMessageService: NzMessageService
    ) {

    }

    ngOnInit() {
        this.load(true);
    }


    load(reset = false) {
        if (reset) {
            this.page.page = 1;
            this.page.args = { name: '' };
            this.page.allChecked = false;
        }
        this.page.loading = true;
        this._MessageClassificationService.getList(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
            this.page.loading = false;
        });
    }

    addOrEdit(params) {
        this._ModalHelper.static(MessageClassificationEdit, { entity: params }).subscribe((res) => {
            if (res) {
                this.load(true);
            }
        });
    }

    setTemplate(entity) {
        this._ModalHelper.static(MessageTemplateDetail, { classificationid: entity.id,classificationName:entity.name }).subscribe((res) => {});
    }

    del() {
        let ids = '';
        this.page.setSelectedRows();
        let data = this.page.selectedRows;
        data.forEach(a => {
            ids += a.id + ',';
        });
        if (ids == '') {
            this._NzMessageService.warning("请选择要删除的行！");
        } else {
            ids = ids.slice(0, -1);
            this._MessageClassificationService.delete(ids).subscribe(res => {
                this._NzMessageService.success(res.message);
                if ((res as any).result == 0) {
                    this.load(true);
                }
            });
        }

    }
}