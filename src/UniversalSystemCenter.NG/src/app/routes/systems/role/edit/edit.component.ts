import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { validateConfig } from '@angular/router/src/config';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { RoleService } from '../role.service'
import { appId, RoleModule } from '../../../../app.global';
import { environment } from '@env/environment';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
    selector: 'role-edit',
    templateUrl: 'edit.component.html',
    providers: [RoleService, ServiceApplicationService]
})

export class RoleEditComponent implements OnInit {
    id: string;
    form: FormGroup;
    app_option: any[];
    _RoleModule: string = RoleModule;//商品主图上传模块

    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public servcie: RoleService,
        public _serviceApplicationService: ServiceApplicationService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [null],
            name: [null, [Validators.required]],
            values: [null],
            icon: [null],
            isEnabled: [true, [Validators.required]],
            sortId: ['0', [Validators.required]],
            appId: [1, [Validators.required]]
        });
        this.loadAppOption();
        if (this.id != null) {
            this.servcie.getById(this.id).subscribe(res => {
                this.form.reset(res);
            });
        }
    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
        });
    }
    save() {
        let resut;
        for (const i in this.form.controls) {
            this.form.controls[i].markAsDirty();
        }
        if (this.id == null) {
            resut = this.servcie.add(this.form.value);
        } else {
            resut = this.servcie.edit(this.form.value);
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
