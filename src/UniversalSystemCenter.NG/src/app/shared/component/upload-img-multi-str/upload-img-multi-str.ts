import { Component, Input, forwardRef } from '@angular/core';
import { UploadFile, NzMessageService } from 'ng-zorro-antd';
import { environment } from '@env/environment';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms'
import { ImgUploadUrl } from 'app/app.global';


@Component({
    selector: 'st-upload-img-multi-str',
    templateUrl: 'upload-img-multi-str.html',
    styleUrls: [
        'upload-img-multi-str.less'
    ],
    providers: [{
        provide: NG_VALUE_ACCESSOR,
        useExisting: forwardRef(() => ST_UploadImgMultiStr),
        multi: true
    }]
})

/**
 * 上传图片-多张 （返回多个图片链接，中间逗号隔开:字符串）
 */
export class ST_UploadImgMultiStr
    implements ControlValueAccessor {
    @Input() ActionUrl: string = environment.FIlE_URL + ImgUploadUrl;//上传地址
    @Input() MaxSize: number = 200;//限制文件大小,默认200KB,如果为0则不限制
    @Input() Disabled: boolean = false;//是否禁用，默认不禁用
    @Input() Module: string = '';//上传模块
    @Input() MaxNum: number = 5;//最大上传数量，默认为5

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
    _ImgStrList: string[] = [];//图片值列表（返回给父组件的字符串通过这个数组生成）

    _Params = {
        module: ''
    };
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


    writeValue(value: string) {
        this._Params.module = this.Module;
        if (value == '' || value == null || value == undefined || value == 'null') {
            this._ImgList = [];
        } else {
            let tempList = [];//push在此处对上传组件不生效，取临时列表，通过赋值的形式能生效

            //将传入的值拼成上传组件相似的对象类型，拥有几个固定属性，方便后面统一取值（主要是编辑时需要）
            let strList = value.split(',');
            strList.forEach(
                (item, index) => {
                    tempList.push(
                        {
                            uid: index + 1,
                            url: environment.FIlE_URL + item,
                            status: 'done',
                            response: [
                                {
                                    localUrl: item
                                }
                            ]
                        }
                    );
                }
            );
            this._ImgList = tempList;
            this._ImgStrList = strList;
        }
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
     * 改变事件
     * @param info 
     */
    handleChange(info: { file: UploadFile, fileList: Array<UploadFile> }) {
        if (info.file.status === 'done') {
            this._ImgStrList.push(info.file.response[0].localUrl);
            this.onModelChange(this._ImgStrList.join(','));
        }
        if (info.file.status === 'removed') {
            let rmUrl = info.file.response[0].localUrl;
            let rmIndex = this._ImgStrList.indexOf(rmUrl);
            if (rmIndex > -1) {
                this._ImgStrList.splice(rmIndex, 1);
            }
            this.onModelChange(this._ImgStrList.join(','));
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


