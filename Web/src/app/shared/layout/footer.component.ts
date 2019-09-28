import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from '../../core';

@Component({
  selector: 'app-layout-footer',
  templateUrl: './footer.component.html'
})
export class FooterComponent {
  today: number = Date.now();

  constructor (
    private router: Router,
    private userService: UserService
  ) {}

  logout() {
    this.userService.purgeAuth();
    this.router.navigateByUrl('/');
  }  
}
