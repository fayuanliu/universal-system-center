import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { validateConfig } from '@angular/router/src/config';
import { appId } from '../../../../app.global';
import { ServiceApplicationService } from '../application.service';

@Component({
    selector: 'app-menu-edit',
    templateUrl: './application-edit.html',
    providers: [ServiceApplicationService],
})

export class ApplicationEdit implements OnInit {
    _options: any[];
    entity: any = {};
    form: FormGroup;
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public _service: ServiceApplicationService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [this.entity.id == null ? 0 : this.entity.id],
            name: ['', [Validators.required]],
            note: ['', [Validators.required]],
            clientId: ['', [Validators.required]],
            isEnabled: [0, [Validators.required]],
            registerEnabled: [0, [Validators.required]],
        });

        if (this.entity.id != null) {
            this._service.getById(this.entity.id).subscribe(res => {
                this.form.reset(res);
            });
        }
    }

    save() {
        let resut;
        if (this.entity.id == null) {
            resut = this._service.add(this.form.value);
        } else {
            resut = this._service.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);

            //保存成功 返回修改后的数据到列表
            if (res.result == 0) {
            }
            this.close(true);
        });
    }

    close(opt) {
        this.subject.destroy(opt);
    }
}
