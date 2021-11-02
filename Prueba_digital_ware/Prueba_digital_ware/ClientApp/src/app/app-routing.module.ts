import { NgModule } from '@angular/core'
import { Routes, RouterModule } from '@angular/router'
import { HomeComponent } from './pages/home/home.component'
import { ProfileComponent } from './pages/profile/profile.component'
import { StocksComponent } from './pages/stocks/stocks.component'
import { DxDataGridModule, DxFormModule } from 'devextreme-angular'

const routes: Routes = [
  {
    path: 'bodega',
    component: StocksComponent
  },
  {
    path: 'profile',
    component: ProfileComponent
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '**',
    redirectTo: 'home'
  }
]

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { useHash: true }),
    DxDataGridModule,
    DxFormModule
  ],
  exports: [RouterModule],
  declarations: [HomeComponent, ProfileComponent, StocksComponent]
})
export class AppRoutingModule {}
