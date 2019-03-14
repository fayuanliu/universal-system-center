import { AreaService } from './../area.service';
import { Component, OnInit } from '@angular/core';
import { NzModalRef, NzMessageService } from 'ng-zorro-antd';
import { ModalHelper } from '@delon/theme';
import { FormGroup, FormBuilder, Validators, FormControl, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { validateConfig } from '@angular/router/src/config';


@Component({
    templateUrl: './area-edit.html',
    providers: [
        AreaService
    ]
})
/**
 * 系统管理-区域编辑
 */
export class AreaEdit implements OnInit {
    _options: any[];
    Id;
    ParentId;
    entity: any = {};
    form: FormGroup;
    constructor(
        private modalHelper: ModalHelper,
        private subject: NzModalRef,
        public msgSrv: NzMessageService,
        public _AreaService: AreaService,
        private fb: FormBuilder
    ) { }

    ngOnInit() {
        this.form = this.fb.group({
            id: [null],
            name: ['', [Validators.required]],
            code: ['0'],
            longitude: [0],
            latitude: [0],
            parentId: [this.ParentId],
            Enabled: [true, [Validators.required]],
            isLeave: [false],
            sortId: [0, [Validators.required]]
        }, );

        if (this.Id != null) {
            this._AreaService.getDetail(this.Id).subscribe(res => {
                this.form.reset(res);
            });
        }
    }



    save() {
        let resut;
        if (this.Id == null) {
            resut = this._AreaService.add(this.form.value);
        } else {
            resut = this._AreaService.edit(this.form.value);
        }
        resut.subscribe((res) => {
            this.msgSrv.success(res.message);
            
            //保存成功 返回修改后的数据到列表
            if (res.result == 0) {
                this.close(true);
            }
        });
    }

    close(opt) {
         this.subject.destroy(opt)
    }
}
