import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { NzMessageService } from 'ng-zorro-antd';
import { RoleService } from './role.service';
import { ModalHelper } from '@delon/theme';
import { SetRoleMenuComponent } from './setMenu/setmenu.component';
import { RoleSetPermissionComponent } from './setPermission/setpermission.component';
import { RoleEditComponent } from './edit/edit.component';
import { environment } from '@env/environment';

@Component({
    selector: 'role-list',
    templateUrl: 'role.component.html',
    providers: [RoleService]
})

export class RoleComponent implements OnInit {
    page = new Page();
    fileHost = environment.FIlE_URL
    constructor(
        private message: NzMessageService,
        public service: RoleService,
        private modalHelper: ModalHelper
    ) { }

    ngOnInit() {
        this.load(true);
    }
    load(reset = false) {
        if (reset) {
            this.page.page = 1;
            this.page.args = { name: '' };
            this.page.allChecked = false;
        }
        this.service.getPage(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
        });
    }

    addOrEdit(id = null) {
        this.modalHelper.static(RoleEditComponent, { id: id }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }

    del() {
        var ids = '';
        this.page.setSelectedRows();
        var data = this.page.selectedRows;
        data.forEach(a => {
            ids += a.id + ',';
        });
        if (ids == '') {
            this.message.warning("请选择要删除的行！");
        } else {
            ids = ids.slice(0, -1);
            this.service.delete(ids).subscribe(res => {
                this.message.success(res.message);
                if ((res as any).result == 0) {
                    this.load();
                }
            });
        }

    }

    setMenu(entity) {
        this.modalHelper.static(SetRoleMenuComponent, { entity: entity }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }

    setPermission(entity) {
        this.modalHelper.static(RoleSetPermissionComponent, { roleData: entity }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }
}
