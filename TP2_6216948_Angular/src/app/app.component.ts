import { Component } from '@angular/core';
import {Injectable} from '@angular/core';
import { ServiceRequetesService } from 'src/Services/Leagues.Service';
import { Inject } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})



export class AppComponent {
  title = 'TP2_6216948_Angular';
    constructor(@Inject(ServiceRequetesService)public service:ServiceRequetesService){

    }


    GetAllLeagues(){
      this.service.getAllLeagues();

     }

}
