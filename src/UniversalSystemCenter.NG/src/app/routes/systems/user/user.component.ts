import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { NzMessageService } from 'ng-zorro-antd';
import { UserService } from './user.service';
import { ModalHelper } from '@delon/theme';
import { UserEditComponent } from './edit/edit.component';
import { environment } from '@env/environment';


@Component({
    selector: 'user-list',
    templateUrl: 'user.component.html',
    providers: [UserService]
})

export class UserComponent implements OnInit {
    pageUrl = 'api/userinfo/page';
    params: any = { userName: '' };
    page = new Page();
    imageServer = environment.FIlE_URL;
    constructor(
        private message: NzMessageService,
        public userservice: UserService,
        private modalHelper: ModalHelper
    ) { }

    ngOnInit() {
        this.load(true);
    }

    load(reset = false) {
        if (reset) {
            this.page.page = 1;
            this.page.args = { userName: '', state: null };
            this.page.allChecked = false;
        }
        this.userservice.getPage(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
        });
    }

    edit(entity) {
        this.modalHelper.static(UserEditComponent, { user: entity }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }

    del() {
        let ids = '';
        this.page.setSelectedRows();
        const data = this.page.selectedRows;
        data.forEach(a => {
            ids += a.id + ',';
        });
        if (ids === '') {
            this.message.warning('请选择要删除的行！');
        } else {
            ids = ids.slice(0, -1);
            this.userservice.delete(ids).subscribe(res => {
                this.message.success(res.message);
                if ((res as any).result === 0) {
                    this.load();
                }
            });
        }

    }
}
