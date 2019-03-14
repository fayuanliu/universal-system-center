import { Component, OnInit } from '@angular/core';
import { NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { Page } from '@shared/model/page';
import { ApplicationEdit } from './edit/application-edit';
import { ServiceApplicationService } from './application.service';


@Component({
    templateUrl: 'application.component.html',
    providers: [ServiceApplicationService]
})

export class ApplicationComponent implements OnInit {
    page = new Page();

    constructor(
        private message: NzMessageService,
        private _service: ServiceApplicationService,
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
        this.page.loading = true;
        this._service.getPage(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
            this.page.loading = false;
        });
    }

    edit(data) {
        this.modalHelper.static(ApplicationEdit, { entity: data }).subscribe((res) => {
            if (res) {
                this.load();
            }
        });
    }

    remove() {
    }



}
