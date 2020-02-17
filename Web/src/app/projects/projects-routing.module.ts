import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProjectsComponent } from './projects.component';
import { ProjectsAuthResolver } from './projects-auth-resolver.service';

const routes: Routes = [
  {
    path: '',
    component: ProjectsComponent,
    resolve: {
      isAuthenticated: ProjectsAuthResolver
    }
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProjectsRoutingModule {}
