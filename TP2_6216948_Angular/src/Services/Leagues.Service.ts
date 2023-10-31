import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { League } from '../Models/League';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ServiceRequetesService {

constructor(public http:HttpClient,private router:Router)
 { }

Leagues:League[]=[];
league?:League;

Leagues2:League[]=[];
loginActve:boolean=false;


 ngOnInit(): void {
  this.getAllLeagues();
 }

  getAllLeagues(){
   return this.http.get<any>('http://localhost:7161/api/Leagues').subscribe(x=>{
   
    
    const LeagueFromResponse=x;
    if(this.Leagues.length==0){

  
    for(const league of LeagueFromResponse){
      const leagues= new League(league.id,league.name,league.logo,league.team,league.saisons)
      
      this.Leagues.push(leagues);
    }
  }
    console.log(this.Leagues)

    })

  }



  
  getSpecificLeague(number: number): Observable<League> {
    return this.http.get<League>('http://localhost:7161/api/Leagues/' + number);
  }

  AddLeague(LeagueACreer:League): Observable<League>{

    return this.http.post<League>('http://localhost:7161/api/Leagues', LeagueACreer);
   
  }



  DeleteLeague(leagueId: number): Observable<League> {
    const url = 'http://localhost:7161/api/Leagues/' + leagueId;
    return this.http.delete<League>(url);
  }


updateLeague(league: League): Observable<League> {
    const url = `http://localhost:7161/api/Leagues/${league.id}`;
    return this.http.put<League>(url, league);
  }

 



}
