import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { Page } from '@shared/model/page';

@Injectable()
export class MenuService {
    constructor(public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        return this._http.get(`api/Menu/page?${page.formatToParams()}`);
    }

    getById(id: string) {
        return this._http.get('api/menu/' +id);
    }

    add(entity: any) {
        return this._http.post("api/menu/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/menu/edit","",entity);
    }

    getcascader(Ids:any) {
        return this._http.get("api/menu/cascader",Ids);
    }

    getTree(){
       return this._http.get('api/menu/gettree');
    }

    /**
     * 删除
     * @param ids
     */
    delete(ids) {
        return this._http.delete("api/menu/delete", { ids: ids });
    }
}
