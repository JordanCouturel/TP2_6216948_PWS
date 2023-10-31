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
      this.leagueId = id !== null ? +id : 0; 
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
              console.log('La ligue a été modifiée avec succès:', updatedLeague);
            },
            (error) => {
              console.error('Une erreur est survenue lors de la modification de la ligue:', error);
            }
          );
  
          this.ModifyLeagueNom = '';
          this.ModifyLeagueLogo = '';
          this.ModifyLeagueActve = false;
        } else {
          console.error('La ligue avec ID ' + this.leagueId + ' a pas été trouvée.');
        }
      },
      (error) => {
        console.error('Une erreur est survenue lors de la recuperationd des données:', error);
      }
    );
  }

  

  toggleFormVisibility() {
    this.ModifyLeagueActve = !this.ModifyLeagueActve;
  }







}
