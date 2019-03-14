import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { Page } from '@shared/model/page';

@Injectable()
export class UserService {

    constructor(public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        return this._http.get(`api/userinfo/page?${page.formatToParams()}`);
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
        return this._http.delete("api/userinfo/delete", { ids: ids });
    }

    getcascader() {
        return this._http.get("api/userinfo/cascader");
    }

    GetSelectRole(userId: string) {
        return this._http.get("api/role/SelectRole", { userId: userId });
    }
}
