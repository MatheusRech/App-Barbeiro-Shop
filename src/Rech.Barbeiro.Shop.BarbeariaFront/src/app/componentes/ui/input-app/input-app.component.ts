import { CommonModule } from '@angular/common';
import { Component, Input, forwardRef } from '@angular/core';
import { ControlValueAccessor, FormsModule, NG_VALUE_ACCESSOR } from '@angular/forms';

@Component({
  selector: 'input-app',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [
    {
      provide: NG_VALUE_ACCESSOR,
      useExisting: forwardRef(() => InputAppComponent),
      multi: true
    }
  ],
  templateUrl: './input-app.component.html',
  styleUrl: './input-app.component.scss'
})
export class InputAppComponent implements ControlValueAccessor {

  @Input('label') label: string;
  @Input('tipo') tipoInput: 'text' | 'datetime-local' | 'email' | 'password' | 'number' | 'month' | 'time' | 'week' | 'date' = 'text';

  protected habilitado: boolean = true;
  protected editado: boolean;
  protected valor: any;
  protected onChange: () => void;
  protected onTouched: () => void;

  writeValue(obj: any): void {
    this.valor = obj;
  }

  registerOnChange(fn: any): void {
    this.onChange = fn;
  }

  registerOnTouched(fn: any): void {
    this.onTouched = fn;
  }

  setDisabledState?(isDisabled: boolean): void {
    this.habilitado = isDisabled;
  }

}
