const mongoose = require('mongoose');

const RecordSchema = new mongoose.Schema({
    title: {type: String, required:[true, "Title is required!"]},
    artist: {type: String, required:[true, "Artist is required!"]},
    date: {type: Number, required:[true, "Date is required!"]}
})

mongoose.model('Record', RecordSchema);