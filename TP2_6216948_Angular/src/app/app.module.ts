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



@NgModule({
  declarations: [							
    AppComponent,
      LeaguesComponent,
      TeamsComponent,
      HomeComponent,
      ModifierLigueComponent,
      DetailsParentComponent,
      SignupComponent,
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
    

    ]),

  ],
  providers: [ServiceRequetesService,TeamsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
