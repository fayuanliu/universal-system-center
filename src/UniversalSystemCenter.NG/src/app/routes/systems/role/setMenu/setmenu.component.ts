import { Component, OnInit, ViewChild } from '@angular/core';
import { RoleService } from '../role.service';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { appId } from '../../../../app.global';

@Component({
    selector: 'role-setmenu',
    templateUrl: 'setmenu.component.html',
    providers: [RoleService]
})

export class SetRoleMenuComponent implements OnInit {
    roleId: string;
    @ViewChild('tree') tree;
    treeData = {
        nzTreeNodes: [],
        defaultCheckedKeys: []
    };
    entity: any;
    _isSpinning = true;
    appId = appId;
    constructor(public service: RoleService, private subject: NzModalRef, private msgSrv: NzMessageService, ) { }
    ngOnInit() {
        this.service.getMenuTreeByRole(this.entity.id, this.entity.appId).subscribe((res: any) => {
            this.treeData = res;
            this._isSpinning = false;
        });
    }

    close(opt) {
         this.subject.destroy(opt);
    }

    save() {
        this._isSpinning = true;
        this.service.setRoleMenu(this.tree.getTreeNodes(), this.entity.id).subscribe(res => {
            this.msgSrv.success((res as any).message);
            if ((res as any).result === 0) {
                 this.close(true);
            }
            this._isSpinning = false;
        });
    }
}

