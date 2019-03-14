import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { appId } from '../../../app.global';
import { Page } from '@shared/model/page';
import { ResponsePage } from '@shared/model/result';

@Injectable()
export class ServiceMenuService {

    constructor(public httpClient: HttpClient, public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize);
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                param = param.append(key, page.args[key]);
            });
        }
        return this.httpClient.get<ResponsePage>('api/Menu/page' + '?' + param.toString());

    }

    getById(id: string) {
        // return this._http.get("api/menu/Get/" + id);
        return this._http.get<any>('api/menu/' +id);
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
