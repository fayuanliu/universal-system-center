import { Injectable } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { clientId } from 'app/app.global';

@Injectable()
export class LoginService {

    constructor(public _http: _HttpClient) { }

    login(username, password) {
        const authData = '&ClientId=' + clientId + '&username=' + username + '&password=' + password + '';
        return this._http.post('api/User/UserLogin?_allow_anonymous=true' + authData);
    }
}
