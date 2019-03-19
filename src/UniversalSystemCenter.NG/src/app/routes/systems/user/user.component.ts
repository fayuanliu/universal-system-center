import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';
import { NzMessageService } from 'ng-zorro-antd';
import { UserService } from './user.service';
import { ModalHelper } from '@delon/theme';
import { UserEditComponent } from './edit/edit.component';

@Component({
  templateUrl: 'user.component.html',
})
export class UserComponent implements OnInit {
  page = new Page({ userName: null, state: null });
  constructor(
    private message: NzMessageService,
    public userservice: UserService,
    private modalHelper: ModalHelper,
  ) {}

  ngOnInit() {
    this.load(true);
  }

  load(reset = false) {
    if (reset) {
      this.page.reset();
    }
    this.userservice.getPage(this.page).subscribe((data: any) => {
      this.page.page = data.page;
      this.page.totalCount = data.totalCount;
      this.page.pageSize = data.pageSize;
      this.page.data = data.data;
    });
  }

  edit(entity) {
    this.modalHelper
      .static(UserEditComponent, { user: entity })
      .subscribe(res => {
        if (res) {
          this.load();
        }
      });
  }

  del() {
    this.userservice.delete(this.page.selectedRows.join(',')).subscribe(res => {
      if (res.result === 0) {
        this.message.success(res.message);
        this.load();
      } else {
        this.message.error(res.message);
      }
    });
  }
}
