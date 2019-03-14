import { Component, OnInit, ViewChild } from '@angular/core';
import { NzMessageService, NzModalRef } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { validateConfig } from '@angular/router/src/config';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ServiceOrganizationservice } from '../organizations.service';
import { createWiresService } from 'selenium-webdriver/firefox';
import { RegionService } from '../../../public-service/region.service';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
    selector: 'app-organizations-edit',
    templateUrl: 'edit.component.html',
    providers: [ServiceOrganizationservice, RegionService, ServiceApplicationService]
})
export class OrganizationsEditComponent implements OnInit {
    id: string;
    form: FormGroup;
    cascader: any[];
    entity: any;
    user: any;
    City: any;
    Province: any;
    Quarter: any;
    UseroptionList: any[];
    QuarteroptionList: any[];
    CityoptionList: any[];
    ProvinceoptionList: any[];
    ReferenceUserList: any[];
    region: any[];
    app_option: any[];
    @ViewChild("nzTablecascader") _nzTablecascader: any;///根据对象拿子节点  
    @ViewChild("referenceDetpcascader") _referenceDetpcascader: any;///根据对象拿子节点
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public servcie: ServiceOrganizationservice,
        private fb: FormBuilder,
        private _RegionService: RegionService,
        public _serviceApplicationService: ServiceApplicationService,

    ) {

    }

    nzOnSearch(keyWord: any, type: number) {
        this.servcie.getUserListByKeyWord(keyWord).subscribe((res: any) => {
            if (res) {
                if (type == 1) {
                    this.UseroptionList = res.data;
                }
                else {
                    this.ReferenceUserList = res.data;
                }
            }

        });
    }
    ngOnInit() {
        this.loadAppOption();
        this.form = this.fb.group({
            id: [''],
            name: ['', [Validators.required]],
            type: [0, [Validators.required]],
            state: [true, [Validators.required]],
            isOpen: [false, [Validators.required]],
            parentIdStr: [''],
            Enabled: [true, [Validators.required]],
            sortId: ['0', [Validators.required]],
            referenceDetpStr: [''],
            regionid: [],
            addressDetail: [''],
            orgChargeUid: ['', [Validators.required]],
            parentId: [this.entity.parentId == null ? '' : this.entity.parentId],
            RegionStr: ['', [Validators.required]],
            referenceDetpId: [],
            referenceUid: ['']

        });
        if (this.entity.id != null) {
            this.servcie.getById(this.entity.id).subscribe(res => {
                this.form.reset(res);
                ///**部门负责人*/
                this.servcie.getUserById(this.form.controls['orgChargeUid'].value).subscribe((res: any) => {
                    if (res) {
                        this.UseroptionList = [
                            { label: res.userName, value: parseInt(res.id) }]
                    }
                }
                );
                /**部门推荐人 枚举为2*/
                this.getUserDefaultByKeyWord(this.form.controls['referenceUid'].value, 2);
                this.servcie.getUserById(this.form.controls['referenceUid'].value).subscribe((res: any) => {
                    if (res) {
                        this.ReferenceUserList = [
                            { label: res.userName, value: res.id }
                        ]
                    }
                });
                //获取部门树结构
                this.servcie.getcascader(this.form.controls['referenceDetpId'].value).subscribe((res: any) => {
                    this.cascader = res.optionsList;
                    this.form.controls['referenceDetpStr'].setValue(res.defaultList);
                });
                let params2 = { isFromTop: false, defaultId: this.form.controls['regionid'].value, level: 3 };
                this._RegionService.getTree(params2).subscribe((res: any) => {
                    this.region = res.data.optionsList;
                    this.form.controls['RegionStr'].setValue(res.data.defaultList);
                });
            });
        } else {
            let params = { isFromTop: false, defaultId: null, level: 3 };
            this.servcie.getcascader(this.form.controls['referenceDetpId'].value).subscribe((res: any) => {
                this.cascader = res.optionsList;
            });
            this._RegionService.getTree(params).subscribe((res: any) => {
                this.region = res.data.optionsList;
            });
        }
    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
        });
    }
    getUserDefaultByKeyWord(keyWord: any, type: number) {
        this.servcie.getById(keyWord).subscribe((res: any) => {
            if (res) {
                if (type == 1) {
                    this.UseroptionList = [
                        { label: res.userName, value: res.id }
                    ]
                } else {
                    this.ReferenceUserList = [
                        { label: res.userName, value: res.id }
                    ]
                }
            }
        });
    }
    // /**
    //  * 级联选择的时候，点击鼠标把菜单关闭嗲
    //  * 
    //  */
    blur() {
        this._nzTablecascader._closeMenu();
    }
    referenceDetpcascaderblur() {
        this._referenceDetpcascader._closeMenu();
    }
    save() {
        let resut;
        for (const i in this.form.controls) {
            this.form.controls[i].markAsDirty();
        }
        if (this.form.controls["state"].value == true) {
            this.form.controls["state"].setValue(1)
        }
        else {
            this.form.controls["state"].setValue(0)
        }
        if (this.entity.id == null) {
            resut = this.servcie.add(this.form.value);
        }
        else {
            ///修改的时候没有变化的话，会提交成Object上去
            let reIndex = this.form.value.referenceDetpStr[0];
            if (reIndex != undefined) {

                if (reIndex.label != undefined) {
                    let newreferenceDetpStr = [];
                    for (const i in this.form.value.referenceDetpStr) {
                        newreferenceDetpStr.push(this.form.value.referenceDetpStr[i].value)
                    }
                    this.form.value.referenceDetpStr = newreferenceDetpStr;
                }
            }
            let reIdIndex = this.form.value.RegionStr[0];
            if (reIdIndex.label != undefined) {
                let newRegionStr = [];
                for (const i in this.form.value.RegionStr) {
                    newRegionStr.push(this.form.value.RegionStr[i].value)
                }
                this.form.value.RegionStr = newRegionStr;
            }
            resut = this.servcie.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);
            this.close(true);
        });
    }
    close(opt) {
        this.subject.destroy(opt);
    }

    _console(a) {
        //this.form.controls["addressDetail"].setValue(a);
    }
}
