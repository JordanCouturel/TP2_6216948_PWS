import { Team } from "./Team";

export class DG{

    constructor(

        public id:number,
        public name:string,
        public age:number,
        
        public team?:Team
    ){


    }
}