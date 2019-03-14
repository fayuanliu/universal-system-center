import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
@Injectable()
/**
 * 区域
 */
export class RegionService {

    constructor(private _http: _HttpClient) { }
    
    getTree(params){
        return this._http.get('api/Area/cascader',params);
    }
    GetDefaultValue(params)
    {
        return this._http.get("api/Area/GetDefaultValue",params);
    }
}
