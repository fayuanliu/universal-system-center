import { Injectable } from "@angular/core";
import { _HttpClient } from "@delon/theme";
import { HttpParams } from "@angular/common/http";
import { Page } from "@shared/model/page";


@Injectable()
/**
 * 消息中心-服务类
 */
export class MessageCenterService {
    constructor(private http: _HttpClient) {

    }
}
