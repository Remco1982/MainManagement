import { Routes } from '@angular/router';
import { ProductComponent } from './platform/products/product.component';
import { LoginComponent } from './authentication/login/login.component';
import { AuthGuard } from './core/AuthGuard';
import { RegisterComponent } from './authentication/register/register.component';

export const routes: Routes = [
        { path: 'platform/products', component: ProductComponent },
        { path: 'login', component: LoginComponent},
];
export const appRoutes: Routes = [
        { path: 'login', component: LoginComponent },
        { path: 'register', component: RegisterComponent },
        { 
                path: 'platform',
                canActivate: [AuthGuard],
                children: [
                        { path: 'products', component: ProductComponent },
                        { path: 'products/create', component: ProductComponent },
                        { path: 'products/edit/:id', component: ProductComponent },
                        { path: 'products/:id', component: ProductComponent },
                ]
        },    
]