import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { catchError } from 'rxjs/operators';

import { Page } from '@shared/model/page';
import { ResponsePage } from '@shared/model/result';
@Injectable()
export class UserService {

    constructor(public httpClient: HttpClient, public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize);
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                if(page.args[key]!=null){
                param = param.append(key, page.args[key]);
                }
            });
        }
        return this.httpClient.get<ResponsePage>('api/userinfo/page' + '?' + param.toString());

    }

    getById(id: string) {
        return this._http.get("api/userinfo/" + id);
    }

    add(entity: any) {
        return this._http.post("api/userinfo/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/userinfo/edit", "", entity);
    }

    delete(ids: string) {
        return this._http.delete("api/userinfo/delete", {ids:ids});
    }

    getcascader() {
        return this._http.get("api/userinfo/cascader");
    }

    GetSelectRole(userId:string){
        return this._http.get("api/role/SelectRole",{userId:userId});
    }
}
