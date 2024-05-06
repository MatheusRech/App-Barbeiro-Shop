import { Component } from '@angular/core';
import { InputAppComponent } from '../ui/input-app/input-app.component';
import { BotaoAppDirective } from '../../diretivas/botao-app/botao-app.directive';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [
    InputAppComponent,
    BotaoAppDirective
  ],
  providers: [
    BotaoAppDirective
  ],
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss'
})
export class LoginComponent {

}
