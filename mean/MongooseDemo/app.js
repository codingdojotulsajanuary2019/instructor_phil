const express = require('express');
const app = express();
const PORT = 8888;
const path = require('path');
const mongoose = require('mongoose');
const bodyParser = require('body-parser');

app.use(express.static(path.join(__dirname, './client/static')));

app.use(bodyParser.urlencoded({extended: true}));

app.set('views', path.join(__dirname, './client/views'));
app.set('view engine', 'ejs');

// connects and/or creates the dbs
mongoose.connect('mongodb://localhost/quoting_dojo', { useNewUrlParser: true });
 
// model 
const quoteSchema = new mongoose.Schema({
    name: String,
    quote: String,
    year: Number
});

// setter/getter collection(default lowercase plural)
const Quote = mongoose.model('quote', quoteSchema);
console.log(typeof(Quote));
// expose the mongoose function as the Quote


app.get('/', function(req, res){
    res.render('index');
})
app.get('/quotes', function(req, res) {
    let temp;
    Quote.find({})
    // success
    .then(quotesFromMongo => res.render(quotesToEJS= quotesFromMongo, test= temp ))
    // errors
    .catch(err => res.json(err));
    // or the below, == the same
    // .catch(function(err){
    //     res.send(err);
    // });

    // , function(err, quotesFromMongo) {
    //     // find method invokes a callback, with errors being the first param, and success being the second
    //     if (err) {
    //         console.log(err);
    //     }

    //     res.render('quotes', { quotesToEJS: quotesFromMongo, test: temp });
    // });
    // temp = 8;
    // console.log('Finding quotes');

});

app.post('/quotes', function(req, res) {
    Quote.create(req.body, function(err, result) {
        if (err) { 
            console.log(err);
        }
        console.log(result);
        res.redirect('/quotes');
    });
});

app.listen(PORT, function(){
    console.log(`Listening on port: ${PORT}!`);
})