import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService, UploadFile } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { validateConfig } from '@angular/router/src/config';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { UserService } from '../user.service';
import { ServiceOrganizationservice } from '../../organizations/organizations.service'
import { UserHead } from '../../../../app.global';
@Component({
    selector: 'user-edit',
    templateUrl: 'edit.component.html',
    styles: [`
  :host ::ng-deep .avatar-uploader,
  :host ::ng-deep .avatar-uploader-trigger,
  :host ::ng-deep .avatar {
    width: 150px;
    height: 150px;
    display: block;
  }

  :host ::ng-deep .avatar-uploader {
    display: block;
    border: 1px dashed #d9d9d9;
    border-radius: 6px;
    cursor: pointer;
  }

  :host ::ng-deep .avatar-uploader-trigger {
    display: table-cell;
    vertical-align: middle;
    font-size: 28px;
    color: #999;
  }
  `],
    providers: [UserService, ServiceOrganizationservice]
})

export class UserEditComponent implements OnInit {
    user: any;
    form: FormGroup;
    cascader: any[];
    options = [];
    loading = false;
    avatarUrl: string;
    _userHead = UserHead;
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public servcie: UserService,
        public orgService: ServiceOrganizationservice,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [''],
            userName: ['', [Validators.required]],
            state: ['0', [Validators.required]],
            organizationsIdS: [''],
            userRoleIds: ['', [Validators.required]],
            head: [''],
            sex: [0, [Validators.required]],
        });
        //获取用户信息
        if (this.user.id != null) {
            this.servcie.getById(this.user.id).subscribe((res: any) => {
                this.form.reset(res);
                this.avatarUrl = res.head;
            });
        }
        //获取树结构
        this.orgService.getcascader(this.user.organizationsId).subscribe((res: any) => {
            this.cascader = res.optionsList;
            setTimeout(() => {
                this.form.controls['organizationsIdS'].setValue(res.defaultList);
            }, 300);
        });
        //获取角色
        this.servcie.GetSelectRole(this.user.id).subscribe((res: any) => {
            this.options = res.data.role;
            setTimeout(() => {
                this.form.controls['userRoleIds'].setValue(res.data.userRole);
            }, 200);


        });

    }

    beforeUpload = (file: File) => {
        const isJPG = file.type === 'image/jpeg';
        if (!isJPG) {
            this.msgSrv.error('只能上传jpg文件!');
        }
        const isLt100Kb = file.size / 1024 < 100;
        if (!isLt100Kb) {
            this.msgSrv.error('最大只能上传100KB文件');
        }
        return isJPG && isLt100Kb;
    }

    private getBase64(img: File, callback: (img: any) => void) {
        const reader = new FileReader();
        reader.addEventListener('load', () => callback(reader.result));
        reader.readAsDataURL(img);
    }

    handleChange(info: { file: UploadFile }) {
        if (info.file.status === 'uploading') {
            this.loading = true;
            return;
        }
        this.form.controls.head.setValue(info.file.response[0].localUrl);
        if (info.file.status === 'done') {
            this.getBase64(info.file.originFileObj, (img: any) => {
                this.loading = false;
                this.avatarUrl = img;
            });
        }
    }

    save() {
        let resut;
        for (const i in this.form.controls) {
            this.form.controls[i].markAsDirty();
        }
        if (this.user.id == null) {
            resut = this.servcie.add(this.form.value);
        } else {
            let reIdIndex = this.form.value.organizationsIdS[0];
            if (reIdIndex.label != undefined) {
                let neworganizationsIdS = [];
                for (const i in this.form.value.organizationsIdS) {
                    neworganizationsIdS.push(this.form.value.organizationsIdS[i].value)
                }
                this.form.value.organizationsIdS = neworganizationsIdS;
            }
            resut = this.servcie.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);
            this.close(true);
        });
    }

    close(opt) {
        this.subject.destroy(opt);
    }
}
