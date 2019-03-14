import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { catchError } from 'rxjs/operators';

import { Page } from '@shared/model/page';
import { ResponsePage } from '@shared/model/result';

@Injectable()
export class ResourceService {

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
        return this.httpClient.get<ResponsePage>('api/resource/page' + '?' + param.toString());

    }

    GetTreeList(Type,appId){
        return this._http.post("api/Resource/GetTreeList?type="+Type+"&&appId="+appId);

    }
    getById(id: string) {
        return this._http.get("api/resource/"+id);
    }

    add(entity: any) {
        return this._http.post("api/resource/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/resource/edit", "",entity);
    }

    getcascader(id:string) {
        return this._http.get("api/resource/cascader?id="+id);
    }

    uriExit(uri:string,id:string){
        var param={uri:uri,id:id}
        return this._http.get("api/resource/uriexit",param);
    }

    codeExit(code:string,id:string){
        var param={uri:code,id:id}
        return this._http.get("api/Permission/uriexit",param);
    }

    GetbyResourceId(id:string){
        var param={resId:id}
        return this._http.get("api/Permission/byResourceId",param);
    }

    addPermissionList(data,resId:string){
        var entityJson = JSON.stringify(data);
        let postData = 'list=' + entityJson + '&resId=' + resId + '';
        return this.httpClient.post("api/Permission/addList", postData, {
            headers: new HttpHeaders().set('Content-Type', 'application/x-www-form-urlencoded'),
        });
    }

    addPermission(data){
        return this._http.post("api/Permission/add", "", data);
    }

    editPermission(data){
        return this._http.post("api/Permission/edit", "", data);
    }

    removePermission(id:string){
        return this._http.delete("api/Permission/delete", {id:id});
    }
}
