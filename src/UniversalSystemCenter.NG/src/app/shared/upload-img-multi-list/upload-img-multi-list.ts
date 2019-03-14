import { Component, Input, forwardRef } from '@angular/core';
import { UploadFile, NzMessageService } from 'ng-zorro-antd';
import { environment } from '@env/environment';
import { ControlValueAccessor, NG_VALUE_ACCESSOR } from '@angular/forms'
import { ImgUploadUrl } from '../../app.global';


@Component({
    selector: 'st-upload-img-multi-list',
    templateUrl: 'upload-img-multi-list.html',
    styleUrls: [
        'upload-img-multi-list.less'
    ],
    providers: [{
        provide: NG_VALUE_ACCESSOR,
        useExisting: forwardRef(() => ST_UploadImgMultiList),
        multi: true
    }]
})

/**
 * 上传图片-多张 （返回一个数组，包含多种图片信息）
 */
export class ST_UploadImgMultiList
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
    _ImgInfoList: ImgInfo[] = [];//图片值列表（返回给父组件的值）

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


    writeValue(value: any[]) {
        this._Params.module = this.Module;
        if (value == null || value == undefined) {
            this._ImgList = [];
        } else {
            let tempList = [];//push在此处对上传组件不生效，取临时列表，通过赋值的形式能生效

            value.forEach(
                (item, index) => {
                    let imgInfo: ImgInfo = new ImgInfo();
                    imgInfo.id = item.id;
                    imgInfo.imageName = item.imageName;
                    imgInfo.localUrl = item.localUrl;
                    imgInfo.remoteUrl = item.remoteUrl;
                    imgInfo.height = item.height;
                    imgInfo.width = item.width;
                    this._ImgInfoList.push(imgInfo);

                    tempList.push(
                        {
                            uid: index + 1,
                            url: environment.FIlE_URL + item.localUrl,
                            status: 'done',
                            response: [
                                {
                                    id: item.id,
                                    imageName: item.imageName,
                                    localUrl: item.localUrl,
                                    remoteUrl: item.remoteUrl,
                                    height: item.height,
                                    width: item.width
                                }
                            ]
                        }
                    );
                }
            );

            this._ImgList = tempList;
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
            let res = info.file.response[0];
            let imgInfo: ImgInfo = new ImgInfo();
            imgInfo.id = res.attachmentId;
            imgInfo.imageName = '';//res.fileName;
            imgInfo.localUrl = res.localUrl;
            imgInfo.remoteUrl = res.remoteUrl;
            imgInfo.height = res.height;
            imgInfo.width = res.width;
            this._ImgInfoList.push(imgInfo);
            this.onModelChange(this._ImgInfoList);
        }
        if (info.file.status === 'removed') {
            let rmIndex = this._ImgList.indexOf(info.file);
            if (rmIndex > -1) {
                this._ImgInfoList.splice(rmIndex, 1);
            }
            this.onModelChange(this._ImgInfoList);
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


interface ImgInfo {
    id: string | null;
    localUrl: string | null;
    remoteUrl: string | null;
    imageName: string | null;
    height: number | null;
    width: number | null;
}

class ImgInfo {
    id: string | null;
    localUrl: string | null;
    remoteUrl: string | null;
    imageName: string | null;
    height: number | null;
    width: number | null;
}
