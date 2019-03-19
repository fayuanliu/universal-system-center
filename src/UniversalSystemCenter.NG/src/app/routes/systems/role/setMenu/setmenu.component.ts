import { Component, OnInit, ViewChild } from '@angular/core';
import { RoleService } from '../role.service';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';

@Component({
  templateUrl: 'setmenu.component.html',
})
export class SetRoleMenuComponent implements OnInit {
  roleId: string;
  @ViewChild('tree') tree;
  treeData = {
    nzTreeNodes: [],
    defaultCheckedKeys: [],
  };
  entity: any;
  constructor(
    public service: RoleService,
    private subject: NzModalRef,
    private message: NzMessageService,
  ) {}

  ngOnInit() {
    this.service
      .getMenuTreeByRole(this.entity.id, this.entity.appId)
      .subscribe((res: any) => {
        this.treeData = res;
      });
  }

  save() {
    this.service
      .setRoleMenu(this.tree.getTreeNodes(), this.entity.id)
      .subscribe((res: any) => {
        if (res.result === 0) {
          this.message.success(res.message);
          this.close(true);
        } else {
          this.message.error(res.message);
        }
      });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
