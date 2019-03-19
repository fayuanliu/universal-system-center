import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
// delon
import { AlainThemeModule } from '@delon/theme';
import { DelonABCModule } from '@delon/abc';
import { DelonACLModule } from '@delon/acl';
import { DelonFormModule } from '@delon/form';

// #region third libs
import { NgZorroAntdModule } from 'ng-zorro-antd';
import { CountdownModule } from 'ngx-countdown';
import { TimestampFormatPipe } from './pipe/timestampFormat';
import { EmptyFormatPipe } from './pipe/emptyFormat';
import { FormatUrlPipe } from './pipe/formatUrl';
import { BackgroundUrlPipe } from './pipe/backgroundUrl';
import { ST_UploadImgSingle } from './component/upload-img-single/upload-img-single';
import { ST_UploadImgMultiStr } from './component/upload-img-multi-str/upload-img-multi-str';
import { ST_UploadImgMultiList } from './component/upload-img-multi-list/upload-img-multi-list';
const THIRDMODULES = [NgZorroAntdModule, CountdownModule];
// #endregion

// #region your componets & directives
const COMPONENTS = [
  ST_UploadImgSingle,
  ST_UploadImgMultiStr,
  ST_UploadImgMultiList,
];
const DIRECTIVES = [];
const PIPES = [
  TimestampFormatPipe,
  EmptyFormatPipe,
  FormatUrlPipe,
  BackgroundUrlPipe,
];
// #endregion

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    ReactiveFormsModule,
    AlainThemeModule.forChild(),
    DelonABCModule,
    DelonACLModule,
    DelonFormModule,
    // third libs
    ...THIRDMODULES,
  ],
  declarations: [
    // your components
    ...COMPONENTS,
    ...DIRECTIVES,
    ...PIPES,
  ],
  exports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    AlainThemeModule,
    DelonABCModule,
    DelonACLModule,
    DelonFormModule,
    // third libs
    ...THIRDMODULES,
    // your components
    ...COMPONENTS,
    ...DIRECTIVES,
    ...PIPES,
  ],
})
export class SharedModule {}
