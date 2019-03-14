
import { Component, OnInit,ViewChild } from '@angular/core';
import {  NzMessageService, UploadFile, NzModalRef } from 'ng-zorro-antd';
import { validateConfig } from '@angular/router/src/config';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ModalHelper } from '@delon/theme';
import { environment } from '@env/environment';
import { Page } from '@shared/model/page';
import { ServiceOrganizationservice } from '../organizations.service';
import { RegionService } from '../../../public-service/region.service';
// import { METHODS } from 'http';




@Component({
    templateUrl: 'organizations-Region.html',
    providers: [ServiceOrganizationservice,RegionService]
})

export class OrganizationsRegion implements OnInit {
    id: string;
    form: FormGroup;
    previewVisible = false;
    entity: any;
    loading = false;
    page = new Page();
    region: any[];
    @ViewChild("nzTablecascader") _nzTablecascader:any;///根据对象拿子节点  
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public service: ServiceOrganizationservice,
        private fb: FormBuilder,
        private _RegionService: RegionService
    ) { }

    ngOnInit() {
        this.load(true);
        this.form = this.fb.group({
            id: [this.id],
            regionStr: [],
            organizationsName: [ {value:this.entity.label, disabled: true}],
            regionid:[],
            organizationsId:[this.entity.value]
        });
        let params = { isFromTop: false,defaultId:null,level:3 };
        if (this.id != null) {
            this.service.getRegionById(this.id).subscribe((res: any) => {
                this.form.reset(res);
            });            
            this._RegionService.getTree(params).subscribe((res: any) => {
                this.region = res.data.optionsList;
            });
        }
        else {
            this._RegionService.getTree(params).subscribe((res: any) => {
                this.region = res.data.optionsList;
            });
        }

    }
        // /**
    //  * 级联选择的时候，点击鼠标把菜单关闭嗲
    //  * 
    //  */
    // blur(){
    //     this._nzTablecascader._closeMenu();
    // }
    load(reset = false) {
        if (reset) {
            this.page.page = 1;
            this.page.args = {};
            this.page.allChecked = false;
        }
        this.page.args.OrganizationsId = this.entity.value;
        this.page.loading = true;
        this.service.getOrgRegionPage(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
            this.page.loading = false;
        });
    }
    edit(entity) {

        let params = { isFromTop: false,defaultId:entity.regionId,level:3 };
        this._RegionService.getTree(params).subscribe((res: any) => {
            this.region = res.data.optionsList;
              this.form.controls['regionStr'].setValue(res.data.defaultList);
                this.form.controls['id'].setValue(entity.id);
        });
        // this.service.getregioncascader(entity.regionId).subscribe((res: any) => {
        //     this.region = res.optionsList;
        //     setTimeout(() => {
        //         this.form.controls['regionStr'].setValue(res.defaultList);
        //         this.form.controls['id'].setValue(entity.id);
        //     }, 100);
        // });
        // this.loading = false;
    }

    save() {
        let resut;
        for (const i in this.form.controls) {
            this.form.controls[i].markAsDirty();
        }
        let orgId=this.form.controls["regionStr"].value;
        this.form.value.regionid = orgId[orgId.length - 1];
        if (this.form.controls["id"].value == null) {            
            this.service.addOrgRegionItem(this.form.value).subscribe((res: any) => {
                this.msgSrv.success(res.message);
                this.load(true);
                let OrganizationsId=this.entity.value;
                let organizationsName=this.entity.label;
                this.form.reset();
                this.form.controls["organizationsId"].setValue(OrganizationsId);
                this.form.controls["organizationsName"].setValue(organizationsName);
            });
        } else {
            let reIdIndex= this.form.value.regionStr[0];
            if(reIdIndex.label!=undefined)
            {
                let newRegionStr=[];
                for(const i in this.form.value.regionStr)
                {
                    newRegionStr.push(this.form.value.RegionStr[i].value)
                }
                this.form.value.regionStr=newRegionStr;
                this.form.value.regionid = newRegionStr[newRegionStr.length - 1];
            }
            this.service.editOrgRegionItem(this.form.value).subscribe((res: any) => {
                this.msgSrv.success(res.message);
                this.load(true);
                let OrganizationsId=this.entity.value;
                let organizationsName=this.entity.label;
                this.form.reset();
                this.form.controls["organizationsId"].setValue(OrganizationsId);
                this.form.controls["organizationsName"].setValue(organizationsName);
            });
        }
    }

    close(opt) {
         this.subject.destroy(opt)
    }
    reset() {
        let OrganizationsId=this.entity.value;
        let organizationsName=this.entity.label;
        this.form.reset();
        this.form.controls["organizationsId"].setValue(OrganizationsId);
        this.form.controls["organizationsName"].setValue(organizationsName);
    }


}
