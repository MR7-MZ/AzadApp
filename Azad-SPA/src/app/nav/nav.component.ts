import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authSevice: AuthService) { }

  // tslint:disable-next-line:typedef
  ngOnInit() {
  }

  // tslint:disable-next-line:typedef
  login(){
    this.authSevice.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, error => {
      console.log(error);
    });
  }

  // tslint:disable-next-line:typedef
  logIn() {
    const token = localStorage.getItem('token');
    return !!token;
  }

  // tslint:disable-next-line:typedef
  logout() {
    localStorage.removeItem('token');
    console.log('logged out');
  }

}
