export class Record {
    title: String;
    artist: String;
    date: Number;
    
    constructor(Title?:String, Artist?:String, Date?:Number){
        this.title = Title;
        this.artist = Artist;
        this.date = Date;
    }
}
