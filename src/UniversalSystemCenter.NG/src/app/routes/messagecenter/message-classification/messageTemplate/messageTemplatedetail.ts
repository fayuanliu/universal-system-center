import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MessageClassificationService } from '../message-classification.service';


@Component({
    templateUrl: 'messageTemplatedetail.html'
})
export class MessageTemplateDetail implements OnInit {
    classificationid: number;
    id: number;
    classificationName: string;
    form: FormGroup;
    codeoption = [
        { value: 1, label: '平台' },
        { value: 2, label: '微信' },
    ]
    page = new Page();
    selectedOption;
    CategoryList = [];
    constructor(
        private subject: NzModalRef,
        public message: NzMessageService,
        public service: MessageClassificationService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [this.id],
            name: ['', [Validators.required]],
            title: ['', [Validators.required]],
            sourceId: [''],
            categoryId: [this.classificationid, [Validators.required]],
            content: ['',[Validators.required]],
            isEnabled: [true, [Validators.required]],
            sortId: [0, [Validators.required]],
            sendObject: [0, [Validators.required]],
        });
        this.service.GetSelectCategory().subscribe((res: any) => {
            this.CategoryList = res.data;
            if (this.id != null) {
                this.service.getByIdTemplate(this.id).subscribe((res: any) => {
                    this.form.reset(res);
                });
            }
        });
        this.load(true);
    }

    edit(entity){
        this.id=entity.id;
        this.form.reset(entity);
    }

    load(reset = false) {
        this.page.args = { CategoryId: this.classificationid };
        if (reset) {
            this.page.page = 1;
            this.page.allChecked = false;
        }
        this.service.getListTemplate(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
        });
    }

    save() {
        let result;
        if (this.id == null) {
            result = this.service.addTemplate(this.form.value);
        } else {
            result = this.service.editTemplate(this.form.value);
        }
        result.subscribe((res) => {
            this.message.success(res.message);
            if (res.result == 0) {
                this.load(true);
                this.form.reset();
            }

        });
    }

    close() {
        this.subject.destroy();
    }

    reset(){
        this.form.reset();
    }
}