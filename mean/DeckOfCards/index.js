// Create a Card class. A card should have the following functionality:
//      Each Card should have a suit ("Hearts", "Clubs", "Diamonds", "Spades")
//      Each Card should have a string value (eg, "Ace", "Two", ...., "Queen", "King")
//      Each Card should have a numerical value (1-13)
//      Each Card should have a show method (log the card's information to the console)

class Card {
    constructor(suit, value){
        this.suit = suit;
        this.value = value;
    }
    show(){
        let stringVal;
        switch(this.value)
        {
            case(1):
                stringVal = "Ace";
                break;
            case(11):
                stringVal = "Jack";
                break;
            case(12):
                stringVal = "Queen";
                break;
            case(13):
                stringVal = "King";
                break;
            default:
                stringVal = this.value;
                break;
        }
        return `${stringVal} of ${this.suit}!`;
    }
}


// Create a Deck class. A deck should have the following functionality:
//      The Deck should contain the 52 standard Cards
//      The Deck should be able to shuffle
//      The Deck should be able to reset
//      The Deck should be able to deal a random Card
//      Deal should return the Card that was dealt and remove it from the Deck
class Deck {
    constructor(){
        this.reset();
        this.shuffle();
        this.displayDeck();
    }
    shuffle(){
        for(let i = this.deck.length-1; i > 0; i--){
            let swapIdx = Math.floor(Math.random() * i--);
            let temp = this.deck[i];
            this.deck[i] = this.deck[swapIdx];
            this.deck[swapIdx] = temp;
        }
    }
    
    reset(){
        this.deck = [];
        let suits = ["Clubs", "Spades", "Diamonds", "Hearts"];
        for(let i = 0; i < suits.length; i++){
            for(let x=1; x<=13; x++){
                // create the cards, and push to the deck
                this.deck.push(new Card(suits[i], x));
            }
        }
        console.log(`there are ${this.deck.length} cards in the deck`);
        this.displayDeck();
        console.log('-'.repeat(90));
    }
    deal(){
        return this.deck.pop();
    }
    displayDeck(){
        for(let i = this.deck.length-1; i > 0; i--){
            this.deck[i].show();
        }
    }
}



//  Now create a Player class. A Player should have the following functionality:
//      The Player should have a name
//      The Player should have a hand (an array of cards taken from a Deck)
//      The Player should be able to take a Card (use the deck.deal method)
//      The Player should be able to discard a Card

class Player {
    constructor(name){
        this.name = name;
        this.hand = [];
    }
    take(deck){
        this.hand.push(deck.deal());
    }
    discard(idx){
        if(idx < this.hand.length){
            this.hand.splice(idx, 1);
        }
    }
    displayHand(){
        console.log("=".repeat(70));
        console.log(`\tPlayer: ${this.name}'s hand:`);
        for(let i = 0; i < this.hand.length; i++){
            console.log(`\t\t ${this.hand[i].show()}`);
        }
    }
}

class Game{
    constructor(){
        this.players = [];
        this.deck = new Deck();
    }
    addPlayer(name){
        this.players.push(new Player(name));
    }
    startGame(){
        for(let i = 0; i < this.players.length; i++){
            for(let x = 0; x < 5; x++){
                this.players[i].take(this.deck);
            }
        }
    }
    showPlayersHand(){
        for(let i = 0; i < this.players.length; i++){
            this.players[i].displayHand();
        }
    }
}

const poker = new Game();
poker.addPlayer("Phil");
poker.addPlayer("Cros");
poker.addPlayer("Michael");
poker.addPlayer("Jeremy");
poker.startGame();
poker.showPlayersHand();



function Test(){
    let test = {};
    test.name = "Sylar";

    const pM = ()=>{
        console.log(test);
        console.log(test.name);
    }

    test.getPM = function(){
        pM();
    }

    return test;
}

const test = Test();
test.getPM();