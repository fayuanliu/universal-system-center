import { Component, OnInit } from '@angular/core';
import { Organizationservice } from './organizations.service';
import { ModalHelper } from '@delon/theme';
import { OrganizationsEditComponent } from './edit/edit.component';
import { OrganizationsRegion } from './organizations-Region/organizations-Region';
import { ApplicationService } from '../application/application.service';

@Component({
    templateUrl: 'organizations.component.html',
    styleUrls: ['organizations.component.less']
})

export class OrganizationsComponent implements OnInit {
    data = [];
    table_loading = false;
    searchBtn_loading = false;
    expandDataCache = {};//
    _previewVisible = false;//是否预览图片中
    _previewImage = "null";//预览的图片
    isGetQVCode = false;
    resmessage = "";
    app_option: any[];
    title: '';
    constructor(
        private service: Organizationservice,
        private modalHelper: ModalHelper,
        public _serviceApplicationService: ApplicationService,
    ) { }

    ngOnInit() {
        this.loadOrg();
    }
    addOrEdit(params) {
        this.modalHelper.static(OrganizationsEditComponent, { entity: params }).subscribe((res) => {
            if (res) {
                this.loadOrg();
            }
        });
    }
    SetRegion(params) {
        this.modalHelper.static(OrganizationsRegion, { entity: params }).subscribe((res) => {
            if (res) {
                this.loadOrg();
            }

        });
    }
    SpreadQRCode(params) {
        this.title = params.label;
        this.table_loading = true;
        this.service.getSpreadQRCode(params.value).subscribe((res: any) => {
            if (res.data != null) {
                let url = res.data.qrSrc;
                this._previewImage = url || "null";
                this.isGetQVCode = true;
                this._previewVisible = true;
            }
            else {
                this.resmessage = res.message;
                this.isGetQVCode = false;
                this._previewVisible = true;
            }
            this.table_loading = false;
        })

    }
    loadOrg() {

        this.table_loading = true;
        this.service.GetTreeList().subscribe((res: Array<any>) => {
            this.data = res;
            this.data.forEach(item => {
                this.expandDataCache[item.value] = this.convertTreeToList(item);
            });
            this.table_loading = false;
        });
    }
    convertTreeToList(root) {
        const stack = [], array = [], hashMap = {};
        stack.push({ ...root, level: 0, expand: true });
        while (stack.length !== 0) {
            const node = stack.pop();
            this.visitNode(node, hashMap, array);
            if (node.children) {
                for (let i = node.children.length - 1; i >= 0; i--) {
                    stack.push({ ...node.children[i], level: node.level + 1, expand: false, parent: node });
                }
            }
        }

        return array;
    }

    visitNode(node, hashMap, array) {
        if (!hashMap[node.value]) {
            hashMap[node.value] = true;
            array.push(node);
        }
    }
    collapse(array, data, $event) {
        if ($event === false) {
            if (data.children) {
                data.children.forEach(d => {
                    const target = array.find(a => a.value === d.value);
                    target.expand = false;
                    this.collapse(array, target, false);
                });
            } else {
                return;
            }
        }
    }
}
