import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Team } from 'src/Models/Team';

@Injectable({
  providedIn: 'root'
})
export class TeamsService {

constructor(public http:HttpClient, private route:ActivatedRoute) { }

Teams:Team[]=[]
leagueid:number|null=null;

ngOnInit(): void {
  this.route.paramMap.subscribe((params)=>{
    const leagueId= params.get('leagueId') || '1';
    this.leagueid=parseInt(leagueId);

    console.log( this.leagueid)

    this.GetTeamByID(this.leagueid)
  })
  
}

GetTeamByID(leagueID:number){
  this.http.get<any>('https://localhost:7161/api/Leagues/'+leagueID).subscribe(x=>{

  const TeamsFromResponse=x.teams

  for(const team of TeamsFromResponse){
    const t= new Team(team.id,team.name,team.ville,team.commanditaire,team.leagueID,team.league,team.arenaId,team.arena,team.dgId,team.dg)
    this.Teams.push(t)

  }
  console.log(this.Teams)

  })
}
}
