import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from '../environments/environment';
import { User } from './_models/user';
import { AccountService } from './_services/account.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The dating app';
  users: any;
  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient, private accountService: AccountService) {}

  ngOnInit() {
    this.getUsers();
    this.setCurrentUser();
  }

  setCurrentUser(){
    if(typeof localStorage.getItem('user') === 'string'){
      const user: User = JSON.parse(localStorage.getItem('user')!);
      this.accountService.setCurrentUser(user);
    }
  }

  getUsers(){
    this.http.get(this.baseUrl + 'users/').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }
}
