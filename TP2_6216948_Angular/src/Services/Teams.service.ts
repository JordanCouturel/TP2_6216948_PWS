import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Team } from 'src/Models/Team';

@Injectable({
  providedIn: 'root'
})
export class TeamsService {

constructor(public http:HttpClient) { }

Teams:Team[]=[]


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
