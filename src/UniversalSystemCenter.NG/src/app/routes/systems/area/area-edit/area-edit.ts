import { AreaService } from './../area.service';
import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';

@Component({
  templateUrl: './area-edit.html',
  providers: [AreaService],
})
/**
 * 系统管理-区域编辑
 */
export class AreaEdit implements OnInit {
  Id;
  ParentId;

  /**
   * 0 新增 ， 1 编辑
   */
  action = 0;

  params = {
    id: null,
    name: null,
    code: 'code',
    longitude: 0,
    latitude: 0,
    parentId: null,
    Enabled: true,
    isLeave: false,
    sortId: 0,
  };

  _options: any[];
  constructor(
    private subject: NzModalRef,
    public msgSrv: NzMessageService,
    public _AreaService: AreaService,
  ) {}

  ngOnInit() {
    this.action = this.Id ? 1 : 0;
    this.params.id = this.Id;
    this.params.parentId = this.ParentId;

    if (this.action == 1) {
      this._AreaService.getDetail(this.Id).subscribe((res: any) => {
        this.params = res;
      });
    }
  }

  save() {
    let resut;
    if (this.action == 0) {
      resut = this._AreaService.add(this.params);
    } else {
      resut = this._AreaService.edit(this.params);
    }
    resut.subscribe(res => {
      //保存成功 返回修改后的数据到列表
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
