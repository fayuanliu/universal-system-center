import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ResourceService } from '../resource.service';
import { appId } from '../../../../app.global';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
    selector: 'app-resource-edit',
    templateUrl: 'edit.component.html',
    providers: [ResourceService, ServiceApplicationService]
})
export class ResourceEditComponent implements OnInit {
    form: FormGroup;
    cascader: any[];
    entity: any;
    app_option: any[];
    appId: any;
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public servcie: ResourceService,
        private fb: FormBuilder,
        public _serviceApplicationService: ServiceApplicationService,
    ) {

    }
    ngOnInit() {
        this.loadAppOption();
        this.form = this.fb.group({
            id: [''],
            uri: ['', [Validators.required]],
            name: ['', [Validators.required]],
            type: [0, [Validators.required]],
            note: [''],
            parentIdStr: [''],
            isEnabled: [true, [Validators.required]],
            sortId: ['0', [Validators.required]],
            parentId: [this.entity.parentId == null ? '' : this.entity.parentId],
            appId: [this.appId]
        });
        if (this.entity.id != null) {
            this.servcie.getById(this.entity.id).subscribe(res => {
                this.form.reset(res);
            });
        }
        //获取树结构
        this.servcie.getcascader(this.entity.id).subscribe((res: any) => {
            this.cascader = res.optionsList;
            setTimeout(() => {
                this.form.controls.parentIdStr.setValue(res.defaultList);
            }, 300);
        });
        console.log(this.appId);

    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
        });
    }
    // uriValidator = (control: FormControl): Observable<any> => {
    //     return ;
    // }

    save() {
        let resut;
        for (const i in this.form.controls) {
            this.form.controls[i].markAsDirty();
        }
        if (this.entity.id == null) {
            resut = this.servcie.add(this.form.value);
        } else {
            resut = this.servcie.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);

            this.close(true);
        });
    }

    close(opt) {
        this.subject.destroy(opt)
    }

    getFormControl(name: string) {
        return this.form.controls[name];
    }

    _console(value) {
        //alert(value);
    }
}
