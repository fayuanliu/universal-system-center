import { HttpParams } from '@angular/common/http';

export class Page {
    /**
     * 页大小
     */
    pageSize: number=10;
    /**
     * 页码
     */
    page: number=1;
    /**
     * 数据
     */
    data: any[] = [];
    /**
     * 搜索条件
     */
    args : any= {};
    /**
     * 是否加载
     */
    loading = false;
    /**
     * 总条数
     */
    totalCount :number;
    /**
     * 是否全选
     */
    allChecked = false;
    /**
     * 当前行
     */
    curRows: any[] = [];
    /**
     * 选中行
     */
    selectedRows: any[] = [];
    /**
     * 半选
     */
    indeterminate = false;
    /**
     * 全选
     */
    checkAll(value: boolean) {
        this.data.forEach(item => item.checked = this.allChecked);
        this.refreshStatus();
    }
    /**
     * 刷新状态
     */
    refreshStatus() {
        const checkedCount = this.data.filter(w => w.checked).length;
        this.allChecked = checkedCount === this.data.length;
        this.indeterminate = this.allChecked ? false : checkedCount > 0;
        this.setSelectedRows();
    }

     /**
     * 选中集合
     */
    setSelectedRows() {
        this.selectedRows = [];
        this.data.forEach(item => {
            if (item.checked == true) {
                this.selectedRows.push(item);
            }
        });
    }

    /**
     * 清除选中集合
     */
    clearSelectedRows(){
        this.allChecked=false;
        this.data.forEach(item => item.checked = this.allChecked);
        this.refreshStatus();
        this.selectedRows = [];
    }

    dataChange(res: any) {
        this.curRows = res;
        this.refreshStatus();
    }

    pageChange(pi: number): Promise<any> {
        alert(pi);
        this.page = pi;
        this.loading = true;
        return new Promise((resolve) => {
            setTimeout(() => {
                this.loading = false;
                resolve();
            }, 500);
        });
    }

    formatToParams(){
        let param = new HttpParams().set('page', '' + this.page).set('pageSize', '' + this.pageSize);
        if (this.args) {
            Object.keys(this.args).forEach(key => {
                param = param.append(key, this.args[key]);
            });
        }
        return param.toString();
    }
}