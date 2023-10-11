import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { League } from 'src/Models/League';
import { ServiceRequetesService } from 'src/Services/Leagues.Service';
import { TeamsService } from 'src/Services/Teams.service';

@Component({
  selector: 'app-Leagues',
  templateUrl: './Leagues.component.html',
  styleUrls: ['./Leagues.component.css']
})
export class LeaguesComponent implements OnInit {

  constructor(public service:ServiceRequetesService,public service2:TeamsService, public router:Router) { }
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


GetTeamsByID(leagueID:number){
  this.service2.GetTeamByID(leagueID)
  }

 

}
