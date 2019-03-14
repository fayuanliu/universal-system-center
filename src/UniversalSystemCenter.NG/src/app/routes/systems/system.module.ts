import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SharedModule } from '@shared/shared.module';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { DefaultInterceptor } from '@core/net/default.interceptor';
import { MenuEditComponent } from './menu/edit/edit.component';

import { MenuComponent } from './menu/menu.component';
import { OrganizationsComponent } from './organizations/organizations.component';
import { OrganizationsEditComponent } from './organizations/edit/edit.component';
import { UserComponent } from './user/user.component';
import { UserEditComponent } from './user/edit/edit.component';
import { RoleComponent } from './role/role.component';
import { SetRoleMenuComponent } from './role/setMenu/setmenu.component';
import { RoleEditComponent } from './role/edit/edit.component';
import { RoleSetPermissionComponent } from './role/setPermission/setpermission.component';
import { ResourceComponent } from './resource/resource.component';
import { ResourceEditComponent } from './resource/edit/edit.component';
import { ResourceSetPermissionComponent } from './resource/setPermission/setpermission.component';
import { CommonModule } from '@angular/common';
import { ApplicationEdit } from './application/edit/application-edit';
import { ApplicationComponent } from './application/application';
import { AreaManager } from './area/area';
import { OrganizationsRegion } from './organizations/organizations-Region/organizations-Region';
import { AreaEdit } from './area/area-edit/area-edit';



const routes: Routes = [
    { path: '', component: UserComponent },
    { path: 'user', component: UserComponent },
    { path: 'menu', component: MenuComponent },
    { path: 'organizations', component: OrganizationsComponent },
    { path: 'role', component: RoleComponent },
    { path: 'resource', component: ResourceComponent },
    { path: 'area', component: AreaManager },
    { path: 'application', component: ApplicationComponent }
];

const COMPONENTS_NOROUNT = [
    UserEditComponent,
    MenuEditComponent,
    OrganizationsEditComponent,
    SetRoleMenuComponent,
    ResourceEditComponent,
    ResourceSetPermissionComponent,
    RoleSetPermissionComponent,
    RoleEditComponent,
    AreaEdit,
    ApplicationEdit,
    OrganizationsRegion
];

@NgModule({
    imports: [
        CommonModule,
        SharedModule,
        RouterModule.forChild(routes)
    ],
    declarations: [
        UserComponent,
        MenuComponent,
        OrganizationsComponent,
        RoleComponent,
        ResourceComponent,
        AreaManager,
        ApplicationComponent,
        SetRoleMenuComponent,
        ResourceEditComponent,
        ResourceSetPermissionComponent,
        RoleSetPermissionComponent,
        RoleEditComponent,
        UserEditComponent,
        ...COMPONENTS_NOROUNT
    ],
    entryComponents: COMPONENTS_NOROUNT,
    exports: [
        RouterModule
    ],
    providers: [
        { provide: HTTP_INTERCEPTORS, useClass: DefaultInterceptor, multi: true },
    ]
})
export class SystemsModule { }
