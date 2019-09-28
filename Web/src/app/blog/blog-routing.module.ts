import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BlogComponent } from './blog.component';
import { BlogAuthResolver } from './blog-auth-resolver.service';

const routes: Routes = [
  {
    path: '',
    component: BlogComponent,
    resolve: {
      isAuthenticated: BlogAuthResolver
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BlogRoutingModule {}
