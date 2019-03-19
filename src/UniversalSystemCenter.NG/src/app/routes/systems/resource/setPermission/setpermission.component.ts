import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormArray,
  FormControl,
} from '@angular/forms';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ResourceService } from '../resource.service';

@Component({
  templateUrl: 'setpermission.component.html',
  styles: [
    `
      nz-table {
        margin: -24px -24px -25px -24px;
      }
    `,
  ],
})
export class ResourceSetPermissionComponent implements OnInit {
  resData: any;
  form: FormGroup;
  editIndex = -1;
  editObj = {};
  isSave = true;
  errMsg: string;
  _isSpinning = true;
  constructor(
    private fb: FormBuilder,
    private subject: NzModalRef,
    private message: NzMessageService,
    public servcie: ResourceService,
  ) {}

  ngOnInit() {
    this.form = this.fb.group({
      items: this.fb.array([]),
    });
    this.servcie.GetbyResourceId(this.resData.value).subscribe((res: any) => {
      res.forEach(i => {
        const field = this.createPermission();
        field.patchValue(i);
        this.items.push(field);
      });
      this._isSpinning = false;
    });
  }

  get items() {
    return this.form.controls.items as FormArray;
  }

  createPermission(): FormGroup {
    return this.fb.group({
      id: [''],
      resourceId: this.resData.value,
      name: ['', [Validators.required]],
      code: ['', [Validators.required]],
      isEnabled: [true, [Validators.required]],
    });
  }

  add() {
    this.items.push(this.createPermission());
    this.edit(this.items.length - 1);
  }

  del(index: number) {
    if (this.items.at(index).value.id) {
      this.servcie
        .removePermission(this.items.at(index).value.id)
        .subscribe(res => {
          this.message.success((res as any).message);
          if ((res as any).result == 0) {
            this.editIndex = -1;
            this.isSave = true;
            this.items.removeAt(index);
          }
        });
    } else {
      this.items.removeAt(index);
    }
  }

  save(index: number) {
    this.items.at(index).markAsDirty();
    if (
      this.items.at(index).value.name == '' ||
      this.items.at(index).value.name == null
    ) {
      this.message.error('请输入权限名称');
      return;
    }
    if (!this.isSave) {
      this.message.error(this.errMsg);
      return;
    }
    if (this.items.at(index).value.id) {
      this.servcie.editPermission(this.items.at(index).value).subscribe(res => {
        this.message.success((res as any).message);
        if ((res as any).result == 0) {
          this.editIndex = -1;
          this.isSave = true;
        }
      });
    } else {
      this.servcie
        .addPermission(this.items.at(index).value)
        .subscribe((res: any) => {
          this.message.success((res as any).message);
          if ((res as any).result == 0) {
            this.items.at(index).value.id = res.data.id;
            this.editIndex = -1;
            this.isSave = true;
          }
        });
    }
  }

  edit(index: number) {
    if (this.editIndex !== -1 && this.editObj) {
      this.items.at(this.editIndex).patchValue(this.editObj);
    }
    this.editObj = { ...this.items.at(index).value };
    this.editIndex = index;
  }

  cancel(index: number) {
    if (!this.items.at(index).value.id) {
      this.del(index);
    } else {
      this.items.at(index).patchValue(this.editObj);
    }
    this.editIndex = -1;
  }

  close(opt) {
    this.subject.destroy(opt);
  }

  saveSub() {
    var data = [];
    for (let index = 0; index < this.items.length; index++) {
      data.push(this.items.at(index).value);
    }
    this.servcie.addPermissionList(data, this.resData.value).subscribe(res => {
      this.message.success((res as any).message);
      if ((res as any).result == 0) {
        this.close(true);
      }
    });
  }
}
