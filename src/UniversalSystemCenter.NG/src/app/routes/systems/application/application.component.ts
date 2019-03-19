import { Component, OnInit } from '@angular/core';
import { NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { Page } from '@shared/model/page';
import { ApplicationEdit } from './edit/application-edit';
import { ApplicationService } from './application.service';

@Component({
  templateUrl: 'application.component.html',
})
export class ApplicationComponent implements OnInit {
  page = new Page({
    name: null,
  });

  constructor(
    private message: NzMessageService,
    public service: ApplicationService,
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

  edit(data) {
    this.modalHelper
      .static(ApplicationEdit, { entity: data })
      .subscribe(res => {
        if (res) {
          this.load();
        }
      });
  }

  del() {
    this.service
      .delete(this.page.selectedRows.join(','))
      .subscribe((res: any) => {
        if (res.result === 0) {
          this.message.success(res.message);
          this.load();
        } else {
          this.message.error(res.message);
        }
      });
  }
}
