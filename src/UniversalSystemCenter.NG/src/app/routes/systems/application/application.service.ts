import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { Page } from '@shared/model/page';

@Injectable()
export class ServiceApplicationService {

    constructor(public _http: _HttpClient) { }
    /**
     * 
     * @param page 分页信息
     */
    getPage(page: Page) {
        return this._http.get(`api/Application/page?${page.formatToParams()}`);
    }

    getById(id: string) {
        return this._http.get<any>('api/Application/' + id);
    }
    getAppOptionList() {
        return this._http.get<any>('api/Application/getSelectData');
    }
    add(entity: any) {
        return this._http.post("api/Application/add/", "", entity);
    }

    edit(entity: any) {
        return this._http.post("api/Application/edit", "", entity);
    }
    delete(ids: string) {
        return this._http.delete("api/Application/delete", { ids: ids })
    }
}
