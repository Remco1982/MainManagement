import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';



@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css'],
  imports: [CommonModule]
})
export class CustomerComponent {
  public customers = [
    { id: 1, name: 'Remco', email: 'remcobaart@outlook.com', phone: '0623379185' },
    { id: 2, name: 'Piet', email: 'pietje@hotmail.com', phone: '0611123441' }
  ];
}