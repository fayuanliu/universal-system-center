import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ApplicationService } from '../application.service';

@Component({
  templateUrl: './application-edit.html',
})
export class ApplicationEdit implements OnInit {
  entity: any = {};
  /**
   * 0 添加  ， 1 编辑
   */
  action: ActionEnum = ActionEnum.ADD;

  params = {
    id: null,
    name: null,
    note: null,
    clientId: null,
    isEnabled: true,
    registerEnabled: true,
  };

  _options: any[];
  constructor(
    private subject: NzModalRef,
    public message: NzMessageService,
    public service: ApplicationService,
  ) {}

  ngOnInit() {
    this.action = this.entity.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.entity.id;

    if (this.action == ActionEnum.EDIT) {
      this.service.getById(this.params.id).subscribe(res => {
        this.params = res;
      });
    }
  }

  save() {
    let resut;
    if (this.action == ActionEnum.ADD) {
      resut = this.service.add(this.params);
    } else {
      resut = this.service.edit(this.params);
    }
    resut.subscribe(res => {
      if (res.result == 0) {
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
