import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { League } from 'src/Models/League';
import { ServiceRequetesService } from 'src/Services/Leagues.Service';

@Component({
  selector: 'app-ModifierLigue',
  templateUrl: './ModifierLigue.component.html',
  styleUrls: ['./ModifierLigue.component.css']
})
export class ModifierLigueComponent implements OnInit {

  constructor(public service:ServiceRequetesService,private route: ActivatedRoute) { }


  ModifyLeagueActve:boolean=false;
  ModifyLeagueNom:string="";
  ModifyLeagueLogo:string="";
  
  leagueAmodifier?:League;

  leagueId: number =0;

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const id = params.get('id');
      this.leagueId = id !== null ? +id : 0; // Convert to number or set to 0 if null
    });

    console.log(this.leagueId)
  }



  onSubmitUpdate(): void {
    this.service.getSpecificLeague(this.leagueId).subscribe(
      (league) => {
        if (league) {
          this.leagueAmodifier = league;
          this.leagueAmodifier.name = this.ModifyLeagueNom;
          this.leagueAmodifier.logo = this.ModifyLeagueLogo;
  
          this.service.updateLeague(this.leagueAmodifier).subscribe(
            (updatedLeague) => {
              console.log('League updated successfully:', updatedLeague);
            },
            (error) => {
              console.error('Error updating league:', error);
            }
          );
  
          this.ModifyLeagueNom = '';
          this.ModifyLeagueLogo = '';
          this.ModifyLeagueActve = false;
        } else {
          console.error('League with ID ' + this.leagueId + ' not found.');
        }
      },
      (error) => {
        console.error('Error fetching league data:', error);
      }
    );
  }

  

  toggleFormVisibility() {
    this.ModifyLeagueActve = !this.ModifyLeagueActve;
  }







}
