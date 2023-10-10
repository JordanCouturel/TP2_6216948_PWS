import { Component, OnInit } from '@angular/core';
import { League } from 'src/Models/League';
import { ServiceRequetesService } from 'src/Services/LeaguesService';

@Component({
  selector: 'app-Leagues',
  templateUrl: './Leagues.component.html',
  styleUrls: ['./Leagues.component.css']
})
export class LeaguesComponent implements OnInit {

  constructor(public service:ServiceRequetesService) { }
leagues:any[]=[]
     
ngOnInit(): void {
  this.GetAllLeagues();
  }
  
     GetAllLeagues(){
      this.service.getAllLeagues();

     }

GetSpecificLeague(id:number){  
  this.service.getSpecificLeague(id)
}


}
