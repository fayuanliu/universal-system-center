import { MessageCenterRoutingModule } from './message-center.routing.module';
import { SharedModule } from '@shared/shared.module';
import { NgModule } from '@angular/core';
import { MessageClassificationEdit } from './message-classification/message-classification-edit/message-classification-edit';
import { MessageClassificationList } from './message-classification/message-classification-list';
import { MessageClassificationService } from './message-classification/message-classification.service';
import { MessageTemplateDetail } from './message-classification/messageTemplate/messageTemplatedetail';

const COMPONENTS = [MessageClassificationList];

const COMPONENTS_NOROUNT = [MessageClassificationEdit, MessageTemplateDetail];

const PROVIDERS = [MessageClassificationService];

@NgModule({
  imports: [SharedModule, MessageCenterRoutingModule],
  declarations: [...COMPONENTS, ...COMPONENTS_NOROUNT],
  entryComponents: COMPONENTS_NOROUNT,
  providers: PROVIDERS,
})

/**
 * 消息中心模块
 */
export class MessageCenterModule {}
