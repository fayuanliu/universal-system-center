import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ServiceMenuService } from '../menu.servcie';
import { validateConfig } from '@angular/router/src/config';
import { appId } from '../../../../app.global';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
    selector: 'app-menu-edit',
    templateUrl: './edit.component.html',
    providers: [ServiceMenuService, ServiceApplicationService],
})

export class MenuEditComponent implements OnInit {
    _options: any[];
    Id;
    ParentId;
    form: FormGroup;
    app_option: any[];
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public _menuService: ServiceMenuService,
        public _serviceApplicationService: ServiceApplicationService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [this.Id],
            name: [null, [Validators.required]],
            isGroup: [(this.ParentId == null || this.ParentId === ''), [Validators.required]],
            link: ['',],
            icon: [''],
            code: ['code'],
            isOpen: [false],
            parentId: [this.ParentId],
            enabled: [true, [Validators.required]],
            sortId: [0, [Validators.required]],
            appId: ['', [Validators.required]]
        });
        this.loadAppOption();
        if (this.Id != null) {
            this._menuService.getById(this.Id).subscribe(res => {
                this.form.reset(res);
            });
        }
        // //获取树结构
        // this.getCascader();
    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
        });
    }
    save() {
        let resut;
        if (this.Id == null) {
            resut = this._menuService.add(this.form.value);
        } else {
            resut = this._menuService.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);

            //保存成功 返回修改后的数据到列表
            if (res.result == 0) {
                this.close(true);
            }

        });
    }

    close(opt) {
        this.subject.destroy(opt);
    }


    // appSelectChange(value) {
    //     this.getCascader();
    // }

    // /**
    //  * 获取树结构
    //  */
    // getCascader() {
    //     this._menuService.getcascader({ Id: this.Id, appId: this.form.controls["appId"].value }).subscribe((res: any) => {
    //         this._options = res.data.optionsList;
    //         setTimeout(() => {
    //             this.form.controls['parentIdStr'].setValue(res.data.defaultList);
    //         }, 100);
    //     });
    // }
}
