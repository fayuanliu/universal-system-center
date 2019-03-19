import { Component, OnInit } from '@angular/core';
import { NzMessageService, NzModalRef } from 'ng-zorro-antd';
import { Organizationservice } from '../organizations.service';
import { RegionService } from '../../../public-service/region.service';
import { ApplicationService } from '../../application/application.service';

@Component({
  templateUrl: 'edit.component.html',
  styles: [
    `
      ::ng-deep .ant-cascader-menu {
        height: 300px!important;
      }
    `,
  ],
})
export class OrganizationsEditComponent implements OnInit {
  entity: any;

  /**
   * 0 新增， 1 编辑
   */
  action = 0;

  params = {
    id: null,
    name: null,
    type: 0,
    state: 1,
    isOpen: false,
    parentIdStr: null,
    Enabled: true,
    sortId: 0,
    referenceDetpStr: null,
    regionid: null,
    addressDetail: null,
    orgChargeUid: null,
    parentId: null,
    RegionStr: null,
    referenceDetpId: null,
    referenceUid: null,
  };

  UseroptionList: any[];
  ReferenceUserList: any[];
  region: any[];
  app_option: any[];

  constructor(
    private subject: NzModalRef,
    public message: NzMessageService,
    public servcie: Organizationservice,
    private _RegionService: RegionService,
    public ApplicationService: ApplicationService,
  ) {}

  ngOnInit() {
    this.loadAppOption();

    this.action = this.entity.id ? 1 : 0;
    this.params.id = this.entity.id;
    this.params.parentId = this.entity.parentId;

    if (this.action == 1) {
      this.servcie.getById(this.entity.id).subscribe((res: any) => {
        this.params = res;

        ///**部门负责人*/
        this.servcie
          .getUserById(this.params.orgChargeUid)
          .subscribe((res: any) => {
            if (res) {
              this.UseroptionList = [
                { label: res.userName, value: res.id },
              ];
            }
          });

        let params2 = {
          isFromTop: false,
          defaultId: this.params.regionid,
          level: 3,
        };
        this._RegionService.getTree(params2).subscribe((res: any) => {
          this.region = res.data.optionsList;
          this.params.RegionStr = res.data.defaultList;
        });
      });
    } else {
      let params = { isFromTop: false, defaultId: null, level: 3 };
      this._RegionService.getTree(params).subscribe((res: any) => {
        this.region = res.data.optionsList;
      });
    }
  }

  nzOnSearch(keyWord: any, type: number) {
    this.servcie.getUserListByKeyWord(keyWord).subscribe((res: any) => {
      if (res) {
        this.UseroptionList = res.data;
      }
    });
  }

  AreaChange(value: Array<any>) {
    if (value && value.length > 0) {
      this.params.parentId = value[value.length - 1];
    } else {
      this.params.parentId = null;
    }
  }

  loadAppOption() {
    this.ApplicationService.getAppOptionList().subscribe((res: any) => {
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
    resut.subscribe(res => {
      this.message.success(res.message);
      this.close(true);
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
