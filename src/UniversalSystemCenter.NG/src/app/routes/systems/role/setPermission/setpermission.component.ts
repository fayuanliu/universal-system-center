import { Component, OnInit } from '@angular/core';
import { RoleService } from '../role.service';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';

@Component({
  selector: 'role-setPermission',
  templateUrl: 'setpermission.component.html',
  providers: [RoleService]
})

export class RoleSetPermissionComponent implements OnInit {
  roleData: any;
  data = [];
  rolePer = [];
  expandDataCache = {};
  _isSpinning = true;
  constructor(private service: RoleService, private subject: NzModalRef, private msgSrv: NzMessageService) {

  }

  ngOnInit() {
    this.service.ResourcePermission(this.roleData.id).subscribe((res: any) => {
      this.data = res;
      this.data.forEach(item => {
        this.expandDataCache[item.id] = this.convertTreeToList(item);
      });
      this._isSpinning=false;
    })
  }

  collapse(array, data, $event) {
    if ($event === false) {
      if (data.children) {
        data.children.forEach(d => {
          const target = array.find(a => a.id === d.id);
          target.expand = false;
          this.collapse(array, target, false);
        });
      } else {
        return;
      }
    }
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
    if (!hashMap[node.id]) {
      hashMap[node.id] = true;
      array.push(node);
    }
  }

  close(opt) {
     this.subject.destroy(opt)
  }

  save() {
    this._isSpinning=true;
    this.data.forEach(a => {
      this.getChildren(a);
    });
    this.service.setRolePermission(this.rolePer).subscribe(res => {
      this.msgSrv.success((res as any).message);
      this._isSpinning=false;
      if ((res as any).result == 0) {
        
         this.close(true);
      }
    })
  }

  getChildren(data) {
    data.checkedBoxList.forEach(b => {
      if (b.checked) {
        var data = { roleId: this.roleData.id, permissionId: b.value }
        this.rolePer.push(data);
      }
    })
    if (data.children.length > 0) {
      data.children.forEach(a => {
        this.getChildren(a);
      })
    }
  }


}