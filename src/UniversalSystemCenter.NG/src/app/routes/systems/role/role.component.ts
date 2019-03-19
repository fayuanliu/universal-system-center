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
  templateUrl: 'role.component.html',
})
export class RoleComponent implements OnInit {
  page = new Page({
    name: null,
  });
  fileHost = environment.FIlE_URL;
  constructor(
    private message: NzMessageService,
    public service: RoleService,
    private modalHelper: ModalHelper,
  ) {}

  ngOnInit() {
    this.load(true);
  }
  load(reset = false) {
    if (reset) {
      this.page.reset();
    }
    this.service.getPage(this.page).subscribe((data: any) => {
      this.page.page = data.page;
      this.page.totalCount = data.totalCount;
      this.page.pageSize = data.pageSize;
      this.page.data = data.data;
    });
  }

  addOrEdit(id = null) {
    this.modalHelper.static(RoleEditComponent, { id: id }).subscribe(res => {
      if (res) {
        this.load();
      }
    });
  }

  del() {
    this.service.delete(this.page.selectedRows.join(',')).subscribe(res => {
      if ((res as any).result == 0) {
        this.message.success(res.message);
        this.load();
      } else {
        this.message.error(res.message);
      }
    });
  }

  setMenu(entity) {
    this.modalHelper
      .static(SetRoleMenuComponent, { entity: entity })
      .subscribe(res => {
        if (res) {
          this.load();
        }
      });
  }

  setPermission(entity) {
    this.modalHelper
      .static(RoleSetPermissionComponent, { roleData: entity })
      .subscribe(res => {
        if (res) {
          this.load();
        }
      });
  }
}
