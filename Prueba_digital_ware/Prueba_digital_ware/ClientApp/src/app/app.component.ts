import { Component, HostBinding } from '@angular/core'
import { ScreenService, AppInfoService } from './shared/services'
const _templateHtml: string = `
  <ng-container>
    <app-side-nav-inner-toolbar title="{{appInfo.title}}">
      <router-outlet></router-outlet>
    </app-side-nav-inner-toolbar>
  </ng-container>`;

@Component({
  selector: 'app-root',
  template: _templateHtml,
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  @HostBinding('class') get getClass() {
    return Object.keys(this.screen.sizes)
      .filter((cl) => this.screen.sizes[cl])
      .join(' ')
  }

  constructor(private screen: ScreenService, public appInfo: AppInfoService) {}
}
