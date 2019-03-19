import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { catchError } from 'rxjs/operators';

import { Page } from '../../../shared/model/page';
import { ResponsePage } from '../../../shared/model/result';

@Injectable()
export class Organizationservice {
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
        return this.httpClient.get<ResponsePage>('api/organizations/page' + '?' + param.toString());

    }

    getById(id: string) {
        return this._http.get("api/organizations/" + id);
    }

    add(entity: any) {
        return this._http.post("api/organizations/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/organizations/edit","", entity);
    }

    getcascader(id:string) {
        return this._http.get("api/organizations/cascader?id="+id);
    }

    GetTreeList(){
        return this._http.post("api/organizations/GetTreeList");

    }
    getUserById(id: string) {
        return this._http.get("api/userinfo/getPersonalDetail", { userid: id });
    }
    getUserList(id){
        return this._http.get("api/organizations/GetUserList/"+id);
    }
    getUserListByKeyWord(keyWord){
        return this._http.get("api/UserInfo/getSelectData/",{keyWord:keyWord});
    }
    GetSelectData(entity:any)
    {
        return this._http.post("api/Area/GetSelectData","", entity);
    }
    getregioncascader(id:string)
    {
        return this._http.get("api/Area/GetRegionCascader?id="+id);
    }
    /**获取推广二维码 */
    getSpreadQRCode(id:string)
    {
        return this._http.get("api/organizations/SpreadQRCode?DeptId="+id);
    }
    getTree(params){
        return this._http.get('api/Area/cascader',params);
    }
    delete(ids){
        return this._http.delete("api/Organizations/delete", {ids:ids});
    }
    getRegionById(id){
        return this._http.get("api/organizations/GetUserList/"+id);
    }
    getOrgRegionPage(page: Page){
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize);
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                if(page.args[key]!=null){
                param = param.append(key, page.args[key]);
                }
            });
        }
        return this.httpClient.get<ResponsePage>('api/OrganizationsRegion/page' + '?' + param.toString());
    }
    addOrgRegionItem(entity:any){
        return this._http.post("api/OrganizationsRegion/add/", "", entity);
    }

    editOrgRegionItem(entity: any) {
        return this._http.post("api/OrganizationsRegion/edit", "", entity);
    }
    getBranchCompany(){
        return this._http.get("api/organizations/BranchCompany")
    }
}