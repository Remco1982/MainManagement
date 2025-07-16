import { Component, Inject } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
// Update the import path below to the correct location of user.service.ts in your project
import { User } from '../../core/dataContracts/userModel';
import { UserService } from '../../core/services/Userservice';

@Component({
  selector: 'app-navigation',
  imports: [RouterModule],
  templateUrl: './navigation.component.html',
  styleUrl: './navigation.component.scss',
  standalone: true,
  providers: [{ provide: UserService, useClass: UserService }]
})
export class NavigationComponent {
  public user: User;

  constructor(private router: Router, @Inject(UserService) private userService: UserService)
  { 
    this.user = this.userService.getUser();
  }

  public loggoff(): void {
    window.localStorage.removeItem('token');
    this.router.navigate(['/login']);
  }
}