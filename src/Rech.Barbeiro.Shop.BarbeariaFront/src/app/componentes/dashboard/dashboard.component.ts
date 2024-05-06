import { Component } from '@angular/core';
import { NavbarAppComponent } from '../ui/navbar-app/navbar-app.component';
import { UsuarioLogadoTemplateComponent } from '../ui/template/usuario-logado-template/usuario-logado-template.component';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [
    UsuarioLogadoTemplateComponent
  ],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.scss'
})
export class DashboardComponent {

}
