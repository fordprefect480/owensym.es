import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { BlogComponent } from './blog.component';
import { BlogAuthResolver } from './blog-auth-resolver.service';
import { SharedModule } from '../shared';
import { BlogRoutingModule } from './blog-routing.module';

@NgModule({
  imports: [
    SharedModule,
    BlogRoutingModule
  ],
  declarations: [
    BlogComponent
  ],
  providers: [
    BlogAuthResolver
  ]
})
export class BlogModule {}
