import { AfterViewInit, Directive, ElementRef, Input, OnInit } from '@angular/core';

@Directive({
  selector: '[botao-app]',
  standalone: true
})
export class BotaoAppDirective implements AfterViewInit {

  constructor(private botao: ElementRef) { }
  
  @Input('tema') tema: 'principal' | 'secundario' | 'alerta' = 'principal';

  ngAfterViewInit(): void {
    this.botao.nativeElement.classList.add('botao-app');

    if(this.tema != 'principal'){
      this.botao.nativeElement.classList.add(this.tema == 'secundario' ? 'secundario' : 'erro');
    }
  }

}
