import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { FormGroup, FormBuilder, Validators, FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LeaguesComponent } from './Leagues/Leagues.component';
import { TeamsComponent } from './Teams/Teams.component';
import { HomeComponent } from './Home/Home.component';
import { ServiceRequetesService } from 'src/Services/Leagues.Service';
import { TeamsService } from 'src/Services/Teams.service';
import { ModifierLigueComponent } from './ModifierLigue/ModifierLigue.component';
import { DetailsParentComponent } from './DetailsParent/DetailsParent.component';
import { SignupComponent } from './Sign-up/Sign-up.component';
import { AuthInterceptorInterceptor } from './auth-interceptor.interceptor';
import { DGsComponent } from './DGs/DGs.component';



@NgModule({
  declarations: [								
    AppComponent,
      LeaguesComponent,
      TeamsComponent,
      HomeComponent,
      ModifierLigueComponent,
      DetailsParentComponent,
      SignupComponent,
      DGsComponent
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule,
    RouterModule.forRoot([
      {path:'',component:AppComponent},
      {path:'ligues',component:LeaguesComponent},
      {path:'Teams/:leagueId',component:TeamsComponent},
      { path: 'ModifierLigue/:id', component: ModifierLigueComponent },
      { path: 'DetailsParent/:id', component: DetailsParentComponent },
      { path: 'FilteredDGs', component: DGsComponent },
    

    ]),

  ],
  providers: [
    ServiceRequetesService, // Other service providers
    TeamsService, // Other service providers
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptorInterceptor, // Add your interceptor class here
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
