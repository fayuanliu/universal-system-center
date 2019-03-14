import { MessageCenterRoutingModule } from './message-center.routing.module';
import { MessageCenterService } from './message-center.service';

import { SharedModule } from '@shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MessageClassificationEdit } from './message-classification/message-classification-edit/message-classification-edit';
import { MessageClassificationList } from './message-classification/message-classification-list';
import { MessageClassificationService } from './message-classification/message-classification.service';
import { MessageTemplateDetail } from './message-classification/messageTemplate/messageTemplatedetail';

const COMPONENTS_NOROUNT = [
    MessageClassificationEdit,
    MessageTemplateDetail
];


@NgModule({
    imports: [
        CommonModule,
        SharedModule,
        MessageCenterRoutingModule
    ],
    declarations: [
        MessageClassificationList,
        ...COMPONENTS_NOROUNT
    ],
    entryComponents: COMPONENTS_NOROUNT,
    providers: [
        MessageCenterService,
        MessageClassificationService,
    ]
})

/**
 * 消息中心模块
 */
export class MessageCenterModule {

}