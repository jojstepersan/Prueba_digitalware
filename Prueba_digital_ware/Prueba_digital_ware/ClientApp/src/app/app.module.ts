import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'
import { AppComponent } from './app.component'
import { SideNavInnerToolbarModule } from './layouts'
import { FooterModule } from './shared/components'
import { ScreenService, AppInfoService } from './shared/services'
import { ProductoService } from '../services/index'
import { AppRoutingModule } from './app-routing.module'
import { HttpClientModule } from '@angular/common/http'

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    SideNavInnerToolbarModule,
    FooterModule,
    AppRoutingModule,
  ],
  providers: [ScreenService, AppInfoService, ProductoService],
  bootstrap: [AppComponent]
})
export class AppModule {}
