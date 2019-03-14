import { Component, Input, forwardRef } from '@angular/core';
import { UploadFile, NzMessageService } from 'ng-zorro-antd';
import { environment } from '@env/environment';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms'
import { ImgUploadUrl } from '../../app.global';


@Component({
    selector: 'st-upload-img-single',
    templateUrl: 'upload-img-single.html',
    styleUrls: [
        'upload-img-single.less'
    ],
    providers: [{
        provide: NG_VALUE_ACCESSOR,
        useExisting: forwardRef(() => ST_UploadImgSingle),
        multi: true
    }]
})

/**
 * 上传图片-单张 （返回图片链接）
 */
export class ST_UploadImgSingle
    implements ControlValueAccessor {
    @Input() ActionUrl: string = environment.FIlE_URL + ImgUploadUrl;//上传地址
    @Input() MaxSize: number = 200;//限制文件大小,默认200KB,如果为0则不限制
    @Input() Disabled: boolean = false;//是否禁用，默认不禁用
    @Input() Module: string = '';//上传模块
    @Input() ReturnValue: string = "localUrl"; //localUrl：返回图片路径  ID：返回附件ID


    _ImgType = '';
    @Input() ImgType = [
        'jpg',
        'jpeg',
        'png',
        'bpm',
        'gif',
        'svg'
    ];//默认图片类型

    _ImgList = [];//图片列表
    private _imgUrl = '';

    _Params = {
        module: ''
    };
    _MaxNum = 1;//最大上传数，默认为1
    _PreviewVisible = false;//是否预览中
    _PreviewImage = '';//预览的图片地址


    constructor(
        private _NzMessageService: NzMessageService
    ) {
        //处理图片类型
        let tempList = [];
        this.ImgType.forEach((v, i, l) => {
            tempList.push('image/' + v);
        });
        this._ImgType = tempList.join(',');
    }


    writeValue(value: any) {
        this._Params.module = this.Module;
        if (value == '' || value == null || value == undefined || value == 'null') {
            this._ImgList = [];
        } else {
            this._ImgList = [
                {
                    uid: 1,
                    url: environment.FIlE_URL + value,
                    status: 'done'
                }
            ];
        }
        this._imgUrl = value;
    }

    registerOnChange(fn: Function): void {
        this.onModelChange = fn;
    }

    registerOnTouched(fn: Function): void {
        this.onModelTouched = fn;
    }

    public onModelChange: Function = () => {

    }

    public onModelTouched: Function = () => {

    };

    /**
     * 上传事件
     * @param info 
     */
    handleChange(info: { file: UploadFile, fileList: Array<UploadFile> }) {
        if (info.file.status === 'done') {
            if (this.ReturnValue === 'ID') {
                this.onModelChange(info.file.response[0].attachmentId);
            }
            else {
                this.onModelChange(info.file.response[0].localUrl);
            }
        }
        if (info.file.status === 'removed') {
            this.onModelChange('');
        }
    }

    /**
     * 上传图片之前的事件
     */
    beforeUpload = (file: File) => {
        if (this.MaxSize <= 0) {
            return true;
        }
        const isLt100Kb = file.size / 1024 < this.MaxSize;
        if (!isLt100Kb) {
            this._NzMessageService.error('只能上传小于' + this.MaxSize + 'KB的图片');
        }
        return isLt100Kb;
    }

    /**
     * 预览图片
     */
    handlePreview = (file: UploadFile) => {
        this._PreviewImage = file.url || file.thumbUrl;
        this._PreviewVisible = true;
    }
}


