import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../_models/user';

import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};
  currentUser$: Observable<User>;  


  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
      this.currentUser$ = this.accountService.currnetUser$;
  }

  login(){
    this.accountService.login(this.model).subscribe(res => {
        console.log(res);
    },error =>{
        console.log(error);
    });
  }

  logout(){
      this.accountService.logout();
      console.log("logged out");
  }

//   getCurrentUser(){
//       this.accountService.currnetUser$.subscribe(user => {
//           //convert obj to bool, if user = null false, if user != null true
//           this.loggedIn = !!user;
//       }, error =>{
//           console.log(error);
//       })
//   }
}
