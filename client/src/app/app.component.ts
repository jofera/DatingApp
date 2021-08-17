import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { environment } from '../environments/environment';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The dating app';
  users: any;
  baseUrl = environment.baseUrl;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUsers();
  }

  getUsers(){
    this.http.get(this.baseUrl + 'users/').subscribe(response => {
      this.users = response;
    }, error => {
      console.log(error);
    })
  }
}
