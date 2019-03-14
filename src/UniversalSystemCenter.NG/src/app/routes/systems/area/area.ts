import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';

import { NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { AreaService } from './area.service';
import { AreaEdit } from './area-edit/area-edit';



interface BreadcrumbItem {
    label: string;
    value: string;
}

class BreadcrumbItem {
    label: string;
    value: string;
    constructor(_value: string, _label: string) {
        this.label = _label;
        this.value = _value;
    }
}

@Component({
    templateUrl: './area.html',
    providers: [
        AreaService
    ],
    styles: [`
        .ant-breadcrumb a{
            color: #108ee9;
        }
    `]
})


/**
 * 系统管理-区域
 */
export class AreaManager implements OnInit {
    page = new Page();

    Breadcrumb_Items: Array<BreadcrumbItem> = [];//面包屑数组

    constructor(
        private _AreaService: AreaService,
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

        if (this.Breadcrumb_Items.length > 0) {
            this.page.args.ParentId = this.Breadcrumb_Items[this.Breadcrumb_Items.length - 1].value;
        } else {
            this.page.args.ParentId = '';
        }

        this._AreaService.getList(this.page).subscribe((res: any) => {
            this.page.page = res.page;
            this.page.totalCount = res.totalCount;
            this.page.pageSize = res.pageSize;
            this.page.data = res.data;
            this.page.loading = false;
        });
    }

    intoChildren(id, name) {
        let lastLeave = new BreadcrumbItem(id, name);
        this.Breadcrumb_Items.push(lastLeave);
        this.load(true);
    }

    returnTo(i) {
        this.Breadcrumb_Items.splice(i + 1, this.Breadcrumb_Items.length - i + 1);
        this.load(true);
    }

    all(){
        this.Breadcrumb_Items = [];
        this.load(true);
    }

    addOrEdit(id = null) {
        let ParentId = '';
        if (this.Breadcrumb_Items.length > 0) {
            ParentId = this.Breadcrumb_Items[this.Breadcrumb_Items.length - 1].value;
        }
        this._ModalHelper.static(AreaEdit, { Id: id, ParentId: ParentId }).subscribe((res) => {
            if (res) {
                this.load();
            } 
        });
    }

    delete(id) {
        this.page.loading = true;
        this._AreaService.delete(id).subscribe((res: any) => {
            this._NzMessageService.success(res.message);
            this.page.loading = false;
            if (res.result == 0) {
                this.load();
            }
        });
    }

    // toHandleCoord(){
    //     this._ModalHelper.static(AreaHandleCoord).subscribe(()=>{
            
    //     });
    // }

}


