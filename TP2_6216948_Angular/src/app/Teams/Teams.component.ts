import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Team } from 'src/Models/Team';
import { TeamsService } from 'src/Services/Teams.service';

@Component({
  selector: 'app-Teams',
  templateUrl: './Teams.component.html',
  styleUrls: ['./Teams.component.css']
})
export class TeamsComponent implements OnInit {

  constructor(public service:TeamsService, private route:ActivatedRoute) { }

  Teams:Team[]=[];


  leagueid:string|null=null;

  ngOnInit() {
    this.GetTeamByID
  }

  GetTeamByID(leagueID:number){
  this.service.GetTeamByID(leagueID) 
  console.log("allo",this.Teams)
  }
 
}
