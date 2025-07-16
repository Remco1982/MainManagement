import { Component, OnInit, Inject } from '@angular/core';
// Update the path below if the actual location is different
// Update the path below to the correct location of user.service.ts
import { UserService } from '../../services/user.service';
// If the correct path is different, for example:
// import { UserService } from '../../../core/services/user.service';
// or
// import { UserService } from '../../services/user.service';

@Component({
  selector: 'app-dashboard',
  imports: [],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent implements OnInit {

  public user: any;
  public tokenTimeValid: number = 0;

  constructor(@Inject(UserService) private userService: UserService) { }

  ngOnInit(): void {
    this.user = this.userService.getUser();
    this.tokenTimeValid = this.userService.getTokenTimeValid();
  }
}