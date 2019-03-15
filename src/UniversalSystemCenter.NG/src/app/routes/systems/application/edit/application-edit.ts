import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ServiceApplicationService } from '../application.service';

@Component({
  selector: 'app-menu-edit',
  templateUrl: './application-edit.html',
  providers: [ServiceApplicationService],
})
export class ApplicationEdit implements OnInit {
  entity: any = {};
  /**
   * 0 添加  ， 1 编辑
   */
  action = 0;

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
    public msgSrv: NzMessageService,
    public _service: ServiceApplicationService,
  ) {}

  ngOnInit() {

    this.action = this.entity.id ? 1 : 0;
    this.params.id = this.entity.id;

    if (this.action == 1) {
      this._service.getById(this.params.id).subscribe(res => {
        this.params = res;
      });
    }
  }

  save() {
    let resut;
    if (this.action == 0) {
      resut = this._service.add(this.params);
    } else {
      resut = this._service.edit(this.params);
    }
    resut.subscribe(res => {
      if (res.result == 0) {
        this.msgSrv.success(res.message);
        this.close(true);
      } else {
        this.msgSrv.error(res.message);
      }
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
