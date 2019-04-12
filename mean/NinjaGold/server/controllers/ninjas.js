const mongoose = require('mongoose');
const Game = mongoose.model('Game');

module.exports = {
    create: (req, res)=>{
        console.log(req.body);
        let game = new Game();
        game.name = req.body.name;
        game.save()
        .then(()=>res.json({status: true, game:game}))
        .catch(err=>res.json({status:false,error:err}))
    },
    update: (req, res)=> {
        const gameId = req.params.id;
        console.log(gameId);
        console.log(req.body);
        Game.findOne({_id: gameId})
        .then(game=>{
            console.log(game);
            game.log = req.body.log;
            game.score = req.body.score;
            console.log(game);
            game.save()
            .then(()=>res.json({status: true, game: game}))
            .catch(err=>res.json({status:false,error: err}))
        })
        .catch(err=>res.json({status:false,error:err}))
    },
    show: (req, res)=> {
        const gameId = req.params.id;
        console.log(gameId);
        Game.findOne({_id:gameId})
        .then(game=>res.json({status: true, game:game}))
        .catch(err=>res.json({status:false,error:err}))
    },
    index: (req, res)=>{
        Game.find()
        .then(game=>res.json({status:true,game:game}))
        .catch(err=>res.json({status:false,error:err}))
    }
}