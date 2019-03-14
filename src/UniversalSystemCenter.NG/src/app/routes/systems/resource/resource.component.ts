import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { NzMessageService } from 'ng-zorro-antd';
import { ResourceService } from './resource.service';
import { ModalHelper } from '@delon/theme';
import { ResourceEditComponent } from './edit/edit.component';
import { ResourceSetPermissionComponent } from './setPermission/setpermission.component';
import { appId } from '../../../app.global';
import { ServiceApplicationService } from '../application/application.service';


@Component({
    selector: 'resource-list',
    templateUrl: 'resource.component.html',
    providers: [ResourceService, ServiceApplicationService]
})

export class ResourceComponent implements OnInit {
    page = new Page();
    data = [];
    table_loading = false;
    expandDataCache = {};
    type = 0;
    appId = null;
    app_option: any[];
    resource_types = [
        { label: "菜单", value: 0 },
        { label: "数据", value: 1 }
    ];
    constructor(
        private message: NzMessageService,
        private resourceService: ResourceService,
        private modalHelper: ModalHelper,
        public _serviceApplicationService: ServiceApplicationService,
    ) { }

    ngOnInit() {
        this.loadAppOption();
    }
    SelectChange(e) {
        this.type = e;
        this.load();
    }
    appSelectChange(e) {
        this.appId = e;
        this.load();
    }
    load() {
        this.table_loading = true;
        this.resourceService.GetTreeList(this.type, this.appId).subscribe((res: Array<any>) => {
            this.data = res;
            this.data.forEach(item => {
                this.expandDataCache[item.value] = this.convertTreeToList(item);
            });
            this.table_loading = false;
        });
    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
            this.appId = res.data[0].value;
            this.load();
        });
    }
    edit(entity) {
        this.modalHelper.static(ResourceEditComponent, { entity: entity, appId: this.appId }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }

    setPermission(entity) {
        this.modalHelper.static(ResourceSetPermissionComponent, { resData: entity }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }
    convertTreeToList(root) {
        const stack = [], array = [], hashMap = {};
        stack.push({ ...root, level: 0, expand: false });
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
    remove() {

    }



}
