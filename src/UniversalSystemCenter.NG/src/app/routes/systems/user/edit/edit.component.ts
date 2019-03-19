import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { UserService } from '../user.service';
import { Organizationservice } from '../../organizations/organizations.service';
import { UserHead } from 'app/app.global';

@Component({
  templateUrl: 'edit.component.html',
})
export class UserEditComponent implements OnInit {
  user: any;
  /**
   * 0 添加  ， 1 编辑
   */
  action: ActionEnum = ActionEnum.ADD;

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
    public message: NzMessageService,
    public servcie: UserService,
    public orgService: Organizationservice,
  ) {}

  ngOnInit() {
    this.action = this.user.id ? ActionEnum.EDIT : ActionEnum.ADD;
    this.params.id = this.user.id;

    //获取用户信息
    if (this.action == ActionEnum.EDIT) {
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

  DeptChange(value) {
    if (value && value.length > 0) {
      this.params.organizationsId = value[value.length - 1];
    } else {
      this.params.organizationsId = null;
    }
  }

  save() {
    let resut;
    if (this.action == ActionEnum.ADD) {
      resut = this.servcie.add(this.params);
    } else {
      resut = this.servcie.edit(this.params);
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
