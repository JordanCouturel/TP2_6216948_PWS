import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { League } from '../Models/League';

@Injectable({
  providedIn: 'root'
})
export class ServiceRequetesService {

constructor(public http:HttpClient)
 { }

Leagues:League[]=[];

 ngOnInit(): void {
  this.getAllLeagues();
 }

  getAllLeagues(){
   return this.http.get<any>('https://localhost:7161/api/Leagues').subscribe(x=>{
   
    
    const LeagueFromResponse=x;

    for(const league of LeagueFromResponse){
      const leagues= new League(league.id,league.name,league.logo,league.team,league.saisons)
      this.Leagues.push(leagues);
    }

    console.log(this.Leagues)

    })

  }


  getSpecificLeague(number:number){
    this.http.get<any>('https://localhost:7161/api/Leagues/'+ number ).subscribe(x=>console.log(x))
    
  }


}
