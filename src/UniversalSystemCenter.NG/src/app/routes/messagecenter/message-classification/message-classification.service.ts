import { Injectable } from "@angular/core";
import { _HttpClient } from "@delon/theme";
import { HttpParams } from "@angular/common/http";
import { Page } from "@shared/model/page";


@Injectable()
/**
 * 消息类型-服务类
 */
export class MessageClassificationService {
    constructor(public http: _HttpClient) {

    }


    /**
     * 获取消息类型列表
     * @param page 
     */
    getList(page:Page){
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize);
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                param = param.append(key, page.args[key]);
            });
        }
        return this.http.get('api/MessageCategory/page?' + param.toString());
    }

    /**
     * 获取消息类型详情
     * @param id 
     */
    getById(id) {
        return this.http.get('api/MessageCategory/' + id);
    }


    /**
     * 添加消息类型
     * @param parmas 
     */
    add(parmas){
        return this.http.post('api/MessageCategory/add','',parmas);
    }

    /**
     * 编辑消息类型
     * @param parmas 
     */
    edit(parmas){
        return this.http.post('api/MessageCategory/edit','',parmas);
    }

    /**
     * 删除消息类型
     * @param ids 
     */
    delete(ids){
        return this.http.delete("api/MessageCategory/delete", {ids:ids});
    }


     /**
     * 获取消息模板列表
     * @param page 
     */
    getListTemplate(page:Page){
        let param = new HttpParams().set('page', '' + page.page).set('pageSize', '' + page.pageSize);
        if (page.args) {
            Object.keys(page.args).forEach(key => {
                param = param.append(key, page.args[key]);
            });
        }
        return this.http.get('api/MessageTemplate/page?' + param.toString());
    }

    /**
     * 获取消息模板详情
     * @param id 
     */
    getByIdTemplate(id) {
        return this.http.get('api/MessageTemplate/' + id);
    }


    /**
     * 添加消息模板
     * @param parmas 
     */
    addTemplate(parmas){
        return this.http.post('api/MessageTemplate/add','',parmas);
    }

    /**
     * 编辑消息模板
     * @param parmas 
     */
    editTemplate(parmas){
        return this.http.post('api/MessageTemplate/edit','',parmas);
    }

    /**
     * 删除消息模板
     * @param ids 
     */
    deleteTemplate(ids){
        return this.http.delete("api/MessageTemplate/delete", {ids:ids});
    }
    
    GetSelectCategory(){
        return this.http.get('api/MessageCategory/getSelectData');
    }
}
