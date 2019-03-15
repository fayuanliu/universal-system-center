import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { RoleService } from '../role.service'
import { ServiceApplicationService } from '../../application/application.service';
import { RoleModule } from 'app/app.global';

@Component({
    selector: 'role-edit',
    templateUrl: 'edit.component.html',
    providers: [RoleService, ServiceApplicationService]
})

export class RoleEditComponent implements OnInit {
    id: string;

    /**
     * 0 添加 ，  1 编辑
     */
    action = 0;

    params = {
        id: null,
        name: null,
        values: null,
        icon: null,
        isEnabled: true,
        sortId: 0,
        appId: null
    };
    app_option: any[];
    _RoleModule: string = RoleModule;//商品主图上传模块

    constructor(
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public servcie: RoleService,
        public _serviceApplicationService: ServiceApplicationService
    ) { }

    ngOnInit() {
        this.action = this.id ? 1 : 0;
        this.params.id = this.id;
        this.loadAppOption();
        if (this.action == 1) {
            this.servcie.getById(this.params.id).subscribe((res : any) => {
                this.params = res;
            });
        }
    }
    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res: any) => {
            this.app_option = res.data;
        });
    }
    save() {
        let resut;
        if (this.action == 0) {
            resut = this.servcie.add(this.params);
        } else {
            resut = this.servcie.edit(this.params);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);
            if (res.result == 0) {
                this.close(true);
            }
        });
    }

    close(opt) {
        this.subject.destroy(opt)
    }
}
