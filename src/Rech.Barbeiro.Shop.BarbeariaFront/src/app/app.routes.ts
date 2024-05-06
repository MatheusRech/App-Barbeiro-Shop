import { Routes } from '@angular/router';
import { LoginComponent } from './componentes';
import { DashboardComponent } from './componentes/dashboard/dashboard.component';

export const rotas = {
    login: 'login',
    dashboard: 'dashboard'
}

export const routes: Routes = [
    { path: rotas.login, component: LoginComponent },
    { path: rotas.dashboard, component: DashboardComponent }
];
