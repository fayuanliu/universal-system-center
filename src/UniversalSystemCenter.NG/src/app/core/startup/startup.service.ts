import { Injectable, Injector, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { zip } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { MenuService, SettingsService, TitleService } from '@delon/theme';
import { DA_SERVICE_TOKEN, ITokenService } from '@delon/auth';
import { ACLService } from '@delon/acl';

import { NzIconService } from 'ng-zorro-antd';
import { ICONS_AUTO } from '../../../style-icons-auto';
import { ICONS } from '../../../style-icons';
import { init_Url } from 'app/app.global';

/**
 * 用于应用启动时
 * 一般用来获取应用所需要的基础数据等
 */
@Injectable()
export class StartupService {
  constructor(
    iconSrv: NzIconService,
    private menuService: MenuService,
    private settingService: SettingsService,
    private aclService: ACLService,
    private titleService: TitleService,
    @Inject(DA_SERVICE_TOKEN) private tokenService: ITokenService,
    private httpClient: HttpClient,
    private injector: Injector,
  ) {
    iconSrv.addIcon(...ICONS_AUTO, ...ICONS);
  }

  private viaHttp(resolve: any, reject: any) {
    zip(this.httpClient.get(init_Url))
      .pipe(
        // 接收其他拦截器后产生的异常消息
        catchError(([appData]) => {
          resolve(null);
          return [appData];
        }),
      )
      .subscribe(
        ([appData]) => {
          if (appData.result == 0) {
            // 应用信息：包括站点名、描述、年份
            this.settingService.setApp(appData.data.app);
            // 用户信息：包括姓名、头像、邮箱地址
            this.settingService.setUser(appData.data.user);
            // ACL：设置权限为全量
            this.aclService.setFull(true);
            // 初始化菜单
            this.menuService.add(appData.data.menu);
            // 设置页面标题的后缀
            this.titleService.suffix = appData.data.app.name;
          }
        },
        () => {},
        () => {
          resolve(null);
        },
      );
  }
  load(): Promise<any> {
    // only works with promises
    // https://github.com/angular/angular/issues/15088
    return new Promise((resolve, reject) => {
      // this.viaHttp(resolve, reject);
      this.viaHttp(resolve, reject);
    });
  }
}
