import { Saison } from "./Saison";
import { Team } from "./Team";

export class League
{
    constructor(public id:number,
                public name:string,
                public logo:string,

                public team:Team[]=[],
                public saisons:Saison[]=[],
                ){

    }
}