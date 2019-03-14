import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { MessageClassificationList } from './message-classification/message-classification-list';


const routes: Routes = [
    { 
        path: "message-classification-list", 
        component: MessageClassificationList 
    }
]

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})

/**
 * 消息中心-路由模块
 */
export class MessageCenterRoutingModule { }