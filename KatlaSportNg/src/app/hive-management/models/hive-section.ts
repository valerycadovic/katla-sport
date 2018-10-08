export class HiveSection {    
    constructor(
        public storeHiveid: number,
        public id: number,
        public name: string,
        public code: string,
        public isDeleted: boolean,
        public lastUpdated: string
    ) { }
}
