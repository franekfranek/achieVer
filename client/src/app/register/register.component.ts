import { Component, EventEmitter, OnInit, Output } from '@angular/core';

import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {}; 
  @Output() cancelRegister = new EventEmitter();

  constructor(private accounService: AccountService) { }

  ngOnInit(): void {
  }

  register(){
    this.accounService.register(this.model).subscribe(res => {
        console.log(res);
        this.cancel();
    }, error =>{
        console.log(error);
    });
  }

  cancel(){
    this.cancelRegister.emit(false);
  }
}
