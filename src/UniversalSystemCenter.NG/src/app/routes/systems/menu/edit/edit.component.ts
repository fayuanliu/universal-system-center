import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ServiceMenuService } from '../menu.servcie';
import { ServiceApplicationService } from '../../application/application.service';

@Component({
    selector: 'app-menu-edit',
    templateUrl: './edit.component.html',
    providers: [ServiceMenuService, ServiceApplicationService],
})

export class MenuEditComponent implements OnInit {
    /**
     * 由其它页面传过来的参数
     */
    qModel;
    /**
     * 0 添加 ，  1 编辑
     */
    action = 0;

    app_option: any[];
    params = {
        id: null,
        name: null,
        isGroup: false,
        link: '',
        icon: '',
        code: 'code',
        isOpen: false,
        parentId: null,
        enabled: true,
        sortId: 0,
        appId: null
    };
    constructor(
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public _menuService: ServiceMenuService,
        public _serviceApplicationService: ServiceApplicationService
    ) { }

    ngOnInit() {
        this.loadAppOption();
        this.action = this.qModel.id ? 1 : 0;
        this.params.id = this.qModel.id;
        this.params.isGroup = this.qModel.parentId ? false : true;
        this.params.parentId = this.qModel.parentId;
        if (this.action == 1) {
            this._menuService.getById(this.params.id).subscribe((res: any) => {
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
            resut = this._menuService.add(this.params);
        } else {
            resut = this._menuService.edit(this.params);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);
            if (res.result == 0) {
                this.close(true);
            }
        });
    }

    close(opt) {
        this.subject.destroy(opt);
    }
}
