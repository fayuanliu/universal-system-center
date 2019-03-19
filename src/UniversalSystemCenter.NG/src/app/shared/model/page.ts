import { HttpParams } from '@angular/common/http';

export class Page {
  /**
   * 页大小（默认值10）
   */
  pageSize: number = 10;
  /**
   * 页码（默认值1）
   */
  page: number = 1;
  /**
   * 数据
   */
  data: any[] = [];
  /**
   * 搜索条件
   */
  args: any = {};
  /**
   * 是否加载
   */
  loading = false;
  /**
   * 总条数
   */
  totalCount: number;
  /**
   * 是否全选
   */
  allChecked = false;
  /**
   * 选中行
   */
  selectedRows: any[] = [];
  /**
   * 半选
   */
  indeterminate = false;

  /**
   * 构造函数
   * @param args 请求参数，例如：{ name : null , id : null }
   */
  constructor(args: any = {}) {
    this.args = args;
  }

  /**
   * 重置
   * @param args 搜索条件（不传入则参数默认设置为null）
   */
  reset(args: any = null) {
    this.page = 1;
    this.allChecked = false;
    this.indeterminate = false;
    if (args) {
      this.args = args;
    } else {
      if (this.args) {
        Object.keys(this.args).forEach(key => {
          this.args[key] = null;
        });
      }
    }
  }

  /**
   * 全选
   */
  checkAll(value: boolean) {
    this.data.forEach(item => (item.checked = this.allChecked));
    this.refreshStatus();
  }
  /**
   * 刷新状态
   */
  refreshStatus() {
    this.selectedRows = this.data.filter(f => f.checked);
    this.allChecked = this.selectedRows.length === this.data.length;
    this.indeterminate = this.allChecked ? false : this.selectedRows.length > 0;
  }
  /**
   * 转为请求参数
   */
  formatToParams() {
    let param = new HttpParams()
      .set('page', '' + this.page)
      .set('pageSize', '' + this.pageSize);
    if (this.args) {
      Object.keys(this.args).forEach(key => {
        if(this.args[key]){
          param = param.append(key, this.args[key]);
        }
      });
    }
    return param.toString();
  }
}
