<<<<<<< HEAD
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    title = 'The Dating App';
    users: any;

    constructor(private http: HttpClient) { }
    ngOnInit(): void {
        this.getUsers();
    }

    getUsers(){
        this.http.get('https://localhost:5001/api/users').subscribe({
            next: respone => this.users = respone,
            error: error => console.log(error)
        });
    }
=======
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'client';
>>>>>>> fc16c54585148279ea0d1e64310a8585ba029c8c
}
