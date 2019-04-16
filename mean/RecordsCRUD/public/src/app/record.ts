export class Record {
    Title: String;
    Artist: String;
    Date: Number;
    
    constructor(Title?:String, Artist?:String, Date?:Number){
        this.Title = Title;
        this.Artist = Artist;
        this.Date = Date;
    }
}
