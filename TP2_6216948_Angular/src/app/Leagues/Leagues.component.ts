import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
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
addLeagueActve:boolean=false;
leagueAcreer?: League;
LeagueAcreer?:League;

addLeagueNom:string="";
addLeagueLogo:string="";

leagueId?: number;
league: League | null = null;


ngOnInit(): void {
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


  async addLeague(leagueAcreer:League):Promise<void>{

    await this.service.AddLeague(leagueAcreer).subscribe(y => {
      console.log('allo',y);
    })
  }
 

  public changeOnClick(): void{
    this.addLeagueActve = !this.addLeagueActve;
  }

  async onSubmit(){
    this.LeagueAcreer = new League(0, this.addLeagueNom, this.addLeagueLogo);
    await this.addLeague(this.LeagueAcreer);
  }



  async DeleteLeague() {
    if (this.leagueId != null) {

       await this.service.DeleteLeague(this.leagueId);

       this.router.navigate(['/ligues']);
       this.router.navigate(['/ligues']);
    }
  }



  setLeagueId(id: number) {
    this.leagueId = id;
  }

}
