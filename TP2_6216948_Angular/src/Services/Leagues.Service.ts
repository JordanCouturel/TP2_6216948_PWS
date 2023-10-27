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





 ngOnInit(): void {
  this.getAllLeagues();
 }

  getAllLeagues(){
   return this.http.get<any>('https://localhost:7161/api/Leagues').subscribe(x=>{
   
    
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



  getSpecificLeague(number:number){
    this.http.get<any>('https://localhost:7161/api/Leagues/'+ number );
    
  }


  AddLeague(LeagueACreer:League): Observable<League>{

    return this.http.post<League>('https://localhost:7161/api/Leagues', LeagueACreer)
   
  }



   DeleteLeague(leagueId:number){
   

     this.http.get<any>('https://localhost:7161/api/Leagues/'+ leagueId ).subscribe(x=>{
      this.league= new League(x.id,x.name,x.logo,x.team,x.league);
      console.log(this.league)
    });

    if(this.league?.team.length===0){
      return this.http.delete<League>('https://localhost:7161/api/Leagues/' + leagueId)

    }
    else{
      return this.router.navigate(['/ligues']);
    }


  }





}
