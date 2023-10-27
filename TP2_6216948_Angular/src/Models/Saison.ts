import { League } from "./League";

export class Saison{
    constructor(
        
        public id:number,
        public dateDebut:string,
        public dateFin:string,
        public annee:number,

        public leagueId?:number,
        public league?:League,

    ){

    }
}