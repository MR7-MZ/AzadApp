import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public authSevice: AuthService , private alertify: AlertifyService) { }

  // tslint:disable-next-line:typedef
  ngOnInit() {
  }

  // tslint:disable-next-line:typedef
  login(){
    this.authSevice.login(this.model).subscribe(next => {
     this.alertify.success('Logged in successfully');
    }, error => {
      this.alertify.error(error);
    });
  }

  // tslint:disable-next-line:typedef
  logIn() {
   return this.authSevice.loggedIn();
  }

  // tslint:disable-next-line:typedef
  logout() {
    localStorage.removeItem('token');
    this.alertify.message('logged out');
  }

}
