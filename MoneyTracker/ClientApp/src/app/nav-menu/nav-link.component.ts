import {Component, Input} from '@angular/core';

@Component({
  selector: 'app-nav-link',
  inputs: ['link', 'name'],
  templateUrl: './nav-link.component.html'
})
export class NavLinkComponent {
  @Input() link: string = '';
  @Input() name: string = '';
}
