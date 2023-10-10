import { Component, OnInit } from '@angular/core';
import { TeamsService } from 'src/Services/Teams.service';

@Component({
  selector: 'app-Teams',
  templateUrl: './Teams.component.html',
  styleUrls: ['./Teams.component.css']
})
export class TeamsComponent implements OnInit {

  constructor(public service:TeamsService) { }

  ngOnInit() {
    this.GetTeamByID
  }

  GetTeamByID(leagueID:number){
  this.service.GetTeamByID(leagueID)
  }
 
}
