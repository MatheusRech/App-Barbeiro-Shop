import { Component, Input } from '@angular/core';
import { NavbarAppComponent } from '../../navbar-app/navbar-app.component';
import { HeaderAppComponent } from '../../header-app/header-app.component';

@Component({
  selector: 'usuario-logado-template',
  standalone: true,
  imports: [
    NavbarAppComponent,
    HeaderAppComponent
  ],
  templateUrl: './usuario-logado-template.component.html',
  styleUrl: './usuario-logado-template.component.scss'
})
export class UsuarioLogadoTemplateComponent {
  @Input('titulo') titulo: string;
}
