import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DG } from 'src/Models/DG';
import { TeamsService } from 'src/Services/Teams.service';

@Component({
  selector: 'app-DGs',
  templateUrl: './DGs.component.html',
  styleUrls: ['./DGs.component.css']
})
export class DGsComponent implements OnInit {

  constructor(public service2:TeamsService, public router:Router) { }


  filteredDGs:DG[]=[];

  agemin:number=0;
  agemax:number=0;

  ngOnInit() {
  }


  loadDGsFilteredByAge(): void {
    this.service2.getDGsfilteredbyAge(this.agemin, this.agemax).subscribe(DGs => { 
     console.log(DGs);

for(let x of DGs)
{
this.filteredDGs.push(new DG(x.id,x.name,x.age))
}
console.log(this.filteredDGs);

         });
       
       }


}
