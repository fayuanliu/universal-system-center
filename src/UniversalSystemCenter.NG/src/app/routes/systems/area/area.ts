import { Component, OnInit } from '@angular/core';
import { Page } from '@shared/model/page';

import { NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { AreaService } from './area.service';
import { AreaEdit } from './area-edit/area-edit';

interface BreadcrumbItem {
  label: string;
  value: string;
}

class BreadcrumbItem {
  label: string;
  value: string;
  constructor(_value: string, _label: string) {
    this.label = _label;
    this.value = _value;
  }
}

@Component({
  templateUrl: './area.html',
  styles: [
    `
      .ant-breadcrumb a {
        color: #108ee9;
      }
    `,
  ],
})

/**
 * 系统管理-区域
 */
export class AreaManager implements OnInit {
  page = new Page({
    name: null,
  });

  Breadcrumb_Items: Array<BreadcrumbItem> = []; //面包屑数组

  constructor(
    public service: AreaService,
    private _ModalHelper: ModalHelper,
    private message: NzMessageService,
  ) {}

  ngOnInit() {
    this.load(true);
  }

  load(reset = false) {
    if (reset) {
      this.page.reset();
    }

    if (this.Breadcrumb_Items.length > 0) {
      this.page.args.ParentId = this.Breadcrumb_Items[
        this.Breadcrumb_Items.length - 1
      ].value;
    } else {
      this.page.args.ParentId = '';
    }

    this.service.getList(this.page).subscribe((res: any) => {
      this.page.page = res.page;
      this.page.totalCount = res.totalCount;
      this.page.pageSize = res.pageSize;
      this.page.data = res.data;
    });
  }

  intoChildren(id, name) {
    let lastLeave = new BreadcrumbItem(id, name);
    this.Breadcrumb_Items.push(lastLeave);
    this.load(true);
  }

  returnTo(i) {
    this.Breadcrumb_Items.splice(i + 1, this.Breadcrumb_Items.length - i + 1);
    this.load(true);
  }

  all() {
    this.Breadcrumb_Items = [];
    this.load(true);
  }

  addOrEdit(id = null) {
    let ParentId = '';
    if (this.Breadcrumb_Items.length > 0) {
      ParentId = this.Breadcrumb_Items[this.Breadcrumb_Items.length - 1].value;
    }
    this._ModalHelper
      .static(AreaEdit, { Id: id, ParentId: ParentId })
      .subscribe(res => {
        if (res) {
          this.load();
        }
      });
  }

  del(id) {
    this.service.delete(id).subscribe((res: any) => {
      if (res.result === 0) {
        this.message.success(res.message);
        this.load();
      } else {
        this.message.error(res.message);
      }
    });
  }

  toHandleCoord() {
    // this._ModalHelper.static(AreaHandleCoord).subscribe(() => {
    // });
  }
}
