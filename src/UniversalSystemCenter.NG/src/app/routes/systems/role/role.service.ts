import { Injectable } from '@angular/core';
import { HttpHeaders } from '@angular/common/http';
import { _HttpClient } from '@delon/theme';
import { Page } from '@shared/model/page';
import { appId } from '../../../app.global';
import { FormatTree } from '@shared/function/formatTree';


@Injectable()
export class RoleService {
    constructor(public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        return this._http.get(`api/role/page?${page.formatToParams()}`);
    }

    getById(id: string) {
        return this._http.get("api/role/" + id);
    }

    add(entity: any) {
        return this._http.post("api/role/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/role/edit", "", entity);
    }

    delete(ids: string) {
        return this._http.delete("api/role/delete", { ids: ids })
    }

    getMenuTreeByRole(id: string, appId: string) {
        return this._http.get("api/role/menutreebyrole?id=" + id + '&&appId=' + appId);
    }

    setRoleMenu(entity, id) {
        const newEntity = FormatTree.formatTree(entity);
        const _params = 'list=' + JSON.stringify(newEntity);
        const header = { headers: new HttpHeaders({ 'Content-Type': 'application/x-www-form-urlencoded' }) };
        return this._http.post('api/role/setrolemenu', _params, { id: id }, header);
    }

    ResourcePermission(id: string) {
        var param = { roleId: id, appId: appId }
        return this._http.get('api/Resource/ResourcePermission', param);
    }

    setRolePermission(data) {
        var entityJson = JSON.stringify(data);
        let _params = 'list=' + entityJson;
        let header = { headers: new HttpHeaders({ 'Content-Type': 'application/x-www-form-urlencoded' }) };
        return this._http.post("api/role/SetRolePermission", _params, '', header);
    }
}
