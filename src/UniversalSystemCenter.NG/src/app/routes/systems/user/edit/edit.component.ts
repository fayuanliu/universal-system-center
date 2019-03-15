import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { UserService } from '../user.service';
import { ServiceOrganizationservice } from '../../organizations/organizations.service';
import { UserHead } from 'app/app.global';

@Component({
  selector: 'user-edit',
  templateUrl: 'edit.component.html',
  providers: [UserService, ServiceOrganizationservice],
})
export class UserEditComponent implements OnInit {
  user: any;
  /**
   * 0 添加  ， 1 编辑
   */
  action = 0;

  params = {
    id: null,
    userName: null,
    state: 0,
    organizationsIdS: null,
    organizationsId: null,
    userRoleIds: null,
    head: null,
    sex: 0,
  };

  cascader: any[];
  options = [];
  _userHead = UserHead;
  constructor(
    private subject: NzModalRef,
    public msgSrv: NzMessageService,
    public servcie: UserService,
    public orgService: ServiceOrganizationservice,
  ) {}

  ngOnInit() {
    this.action = this.user.id ? 1 : 0;
    this.params.id = this.user.id;

    //获取用户信息
    if (this.action == 1) {
      this.servcie.getById(this.user.id).subscribe((res: any) => {
        this.params = res;
        //获取树结构
        this.orgService
          .getcascader(this.params.organizationsId)
          .subscribe((res: any) => {
            this.cascader = res.optionsList;
            this.params.organizationsIdS = res.defaultList;
          });
        //获取角色
        this.servcie.GetSelectRole(this.params.id).subscribe((res: any) => {
          this.options = res.data.role;
          this.params.userRoleIds = res.data.userRole;
        });
      });
    } else {
      //获取树结构
      this.orgService
        .getcascader(this.params.organizationsId)
        .subscribe((res: any) => {
          this.cascader = res.optionsList;
        });
      //获取角色
      this.servcie.GetSelectRole(this.params.id).subscribe((res: any) => {
        this.options = res.data.role;
      });
    }
  }

  DeptChange(value){
    if (value && value.length > 0) {
        this.params.organizationsId = value[value.length - 1];
      } else {
        this.params.organizationsId = null;
      }
  }

  save() {
    let resut;
    if (this.action == 0) {
      resut = this.servcie.add(this.params);
    } else {
      resut = this.servcie.edit(this.params);
    }
    resut.subscribe(res => {
      this.msgSrv.success(res.message);
      this.close(true);
    });
  }

  close(opt) {
    this.subject.destroy(opt);
  }
}
