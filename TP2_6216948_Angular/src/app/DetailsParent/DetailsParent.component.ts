import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { League } from 'src/Models/League';
import { ServiceRequetesService } from 'src/Services/Leagues.Service';
import { TeamsService } from 'src/Services/Teams.service';

@Component({
  selector: 'app-DetailsParent',
  templateUrl: './DetailsParent.component.html',
  styleUrls: ['./DetailsParent.component.css']
})
export class DetailsParentComponent implements OnInit {

  constructor(public route:ActivatedRoute,public service:ServiceRequetesService,public service2:TeamsService) { }

  leagueId: number =0;
  league?:League; 

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');


      this.leagueId = id !== null ? +id : 0; 
    });

    this.detailsparent();
}



detailsparent(){
  this.service.getSpecificLeague(this.leagueId).subscribe(x=>{
   
    this.league=x;
    console.log(this.league);
  })

  this.service2.GetTeamByID(this.leagueId)
}
}