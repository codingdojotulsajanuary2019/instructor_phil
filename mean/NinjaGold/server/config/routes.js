const Game = require('./../controllers/ninjas');

module.exports=(app)=>{
    app.post('/ninjaGold', Game.create)
    app.put('/ninjaGold/:id', Game.update)
    app.get('/ninjaGold/:id', Game.show)
    app.get('/ninjaGold', Game.index)
}