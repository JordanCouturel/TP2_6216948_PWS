import { Arena } from "./Arena";
import { DG } from "./DG";
import { League } from "./League";

export class Team{


    constructor(
        public id:number,
        public name:string,
        public ville:string,
        public commanditaire:string,

        public leagueId?:number,
        public league?:League,

        public arenaId?:number,
        public arena?:Arena,

        public dgId?:number,
        public dg?:DG,



    ){}

}