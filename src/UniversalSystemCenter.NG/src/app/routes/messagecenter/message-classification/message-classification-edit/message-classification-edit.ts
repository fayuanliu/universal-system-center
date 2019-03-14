import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ModalHelper } from '@delon/theme';
import { MessageClassificationService } from '../message-classification.service';


@Component({
    templateUrl: 'message-classification-edit.html'
})
export class MessageClassificationEdit implements OnInit {
    entity: any;
    form: FormGroup;
    TypeOptions = [
        { value: 0, label: '通知' },
        { value: 1, label: '消息' },
        { value: 2, label: '待办' },
    ];
    AppTypeoption = [
        { value: 0, label: '中央系统' },
        { value: 1, label: '约车Wap' },
        { value: 2, label: '平台管理' },
    ]
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public _MessageClassificationService: MessageClassificationService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [0],
            name: ['', [Validators.required]],
            sortId: [0, [Validators.required]],
            isEnabled: [true],
            type: [0, [Validators.required]],
            appType: [0, [Validators.required]],
        });
        if (this.entity.id != null) {
            this._MessageClassificationService.getById(this.entity.id).subscribe(res => {
                this.form.reset(res);
            });
        }
    }


    save() {
        let resut;
        if (this.entity.id == null) {
            resut = this._MessageClassificationService.add(this.form.value);
        } else {
            resut = this._MessageClassificationService.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);

            if (res.result == 0) {
                this.close(true);
            }

        });
    }

    close(opt) {
        this.subject.destroy(opt)
    }
}
