import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ProjectsComponent } from './projects.component';
import { ProjectsAuthResolver } from './projects-auth-resolver.service';
import { SharedModule } from '../shared';
import { ProjectsRoutingModule } from './projects-routing.module';

@NgModule({
  imports: [
    SharedModule,
    ProjectsRoutingModule
  ],
  declarations: [
    ProjectsComponent
  ],
  providers: [
    ProjectsAuthResolver
  ]
})
export class ProjectsModule {}
