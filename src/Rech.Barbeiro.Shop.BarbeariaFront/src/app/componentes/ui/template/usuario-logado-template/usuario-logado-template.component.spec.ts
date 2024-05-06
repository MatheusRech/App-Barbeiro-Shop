import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsuarioLogadoTemplateComponent } from './usuario-logado-template.component';

describe('UsuarioLogadoTemplateComponent', () => {
  let component: UsuarioLogadoTemplateComponent;
  let fixture: ComponentFixture<UsuarioLogadoTemplateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [UsuarioLogadoTemplateComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(UsuarioLogadoTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
