const mongoose = require('mongoose');

const GameSchema = new mongoose.Schema({
    score:{type: Number, default:0},
    log: {type: Array, default:[]},
    player: {type: String}
}, {timestamps:true});

mongoose.model('Game', GameSchema);