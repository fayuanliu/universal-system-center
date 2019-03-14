import { Component, OnInit } from '@angular/core';
import { NzMessageService } from 'ng-zorro-antd';
import { ServiceMenuService } from './menu.servcie';
import { ModalHelper } from '@delon/theme';
import { MenuEditComponent } from './edit/edit.component';
import { Page } from '@shared/model/page';
import { ServiceApplicationService } from '../application/application.service';


interface BreadcrumbItem {
    label: string;
    value: string;
}

class BreadcrumbItem {
    label: string;
    value: string;
    constructor(_value: string, _label: string) {
        this.label = _label;
        this.value = _value;
    }
}

@Component({
    selector: 'menu-list',
    templateUrl: 'menu.component.html',
    providers: [ServiceMenuService,ServiceApplicationService]
})

export class MenuComponent implements OnInit {
    page = new Page();
    Breadcrumb_Items: Array<BreadcrumbItem> = [];//面包屑数组
    app_option: any[];
    constructor(
        private message: NzMessageService,
        private menuservice: ServiceMenuService,
        public _serviceApplicationService :ServiceApplicationService,
        private modalHelper: ModalHelper
    ) { }

    ngOnInit() {
        this.load(true);
        this.loadAppOption();
    }

    loadAppOption() {
        this._serviceApplicationService.getAppOptionList().subscribe((res:any)=>{
            this.app_option=res.data;
        });
    }

    /**
     * 
     * @param reset 是否重置
     * @param isturn 是否点击顶部菜单跳转
     */
    load(reset = false,isturn = false) {

        //重置所有参数
        if (reset) {
            this.page.page = 1;
            this.page.args = { name: '' };
            this.page.allChecked = false;
        }
        this.page.loading = true;

        //重置页码，不重置表单参数
        if(isturn){
            this.page.page = 1;
            this.page.allChecked = false;
        }

        if (this.Breadcrumb_Items.length > 0) {
            this.page.args.ParentId = this.Breadcrumb_Items[this.Breadcrumb_Items.length - 1].value;
        } else {
            this.page.args.ParentId = '';
        }

        this.menuservice.getPage(this.page).subscribe((data: any) => {
            this.page.page = data.page;
            this.page.totalCount = data.totalCount;
            this.page.pageSize = data.pageSize;
            this.page.data = data.data;
            this.page.loading = false;
        });
    }

    intoChildren(id, name) {
        let lastLeave = new BreadcrumbItem(id, name);
        this.Breadcrumb_Items.push(lastLeave);
        this.load(false,true);
    }

    returnTo(i) {
        this.Breadcrumb_Items.splice(i + 1, this.Breadcrumb_Items.length - i + 1);
        this.load(false,true);
    }

    all(){
        this.Breadcrumb_Items = [];
        this.load(false,true);
    }

    addOrEdit(id = null) {
        let ParentId = '';
        if (this.Breadcrumb_Items.length > 0) {
            ParentId = this.Breadcrumb_Items[this.Breadcrumb_Items.length - 1].value;
        }
        this.modalHelper.static(MenuEditComponent, { Id: id, ParentId: ParentId }).subscribe((res) => {
            if (res) {
                this.load(false,true);
            }
        });
    }

    delete(id) {
        this.page.loading = true;
        this.menuservice.delete(id).subscribe((res: any) => {
            this.message.success(res.message);
            this.page.loading = false;
            if (res.result == 0) {
                this.load(false,true);
            }
        });
    }
}
