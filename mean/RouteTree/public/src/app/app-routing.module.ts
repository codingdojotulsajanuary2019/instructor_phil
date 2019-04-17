import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AlphaComponent } from './alpha/alpha.component';
import { BetaComponent } from './beta/beta.component';
import { GammaComponent } from './gamma/gamma.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { ChildTwoComponent } from './beta/child-two/child-two.component';
import { ChildOneComponent } from './beta/child-one/child-one.component';

const routes: Routes = [
  { path: 'alpha',component: AlphaComponent},
  { path: 'beta',component: BetaComponent, children: [
    { path: 'childOne', component: ChildOneComponent},
    { path: 'childTwo', component: ChildTwoComponent}
  ]},
  // use a colon and parameter name to include a parameter in the url
  { path: 'gamma/:gamma_id', component: GammaComponent },
  // redirect to /alpha if there is nothing in the url
  { path: '', pathMatch: 'full', redirectTo: '/alpha' },
  // the ** will catch anything that did not match any of the above routes
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
