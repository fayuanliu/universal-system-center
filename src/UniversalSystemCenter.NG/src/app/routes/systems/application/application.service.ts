import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { appId } from '../../../app.global';
import { Page } from '@shared/model/page';
import { ResponsePage } from '@shared/model/result';

@Injectable()
export class ServiceApplicationService {

    constructor(public httpClient: HttpClient, public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize).set('appId',appId.toString());
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                param = param.append(key, page.args[key]);
            });
        }
        return this.httpClient.get<ResponsePage>('api/Application/page' + '?' + param.toString());

    }

    getById(id: string) {
        // return this._http.get("api/Application/Get/" + id);
        return this._http.get<any>('api/Application/' +id);
    }
    getAppOptionList() {
        return this._http.get<any>('api/Application/getSelectData');
    }
    add(entity: any) {
        return this._http.post("api/Application/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/Application/edit","",entity);
    }
    delete(ids:string){
        return this._http.delete("api/Application/delete",{ids:ids})
    }
}
