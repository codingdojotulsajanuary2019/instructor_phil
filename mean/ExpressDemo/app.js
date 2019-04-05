var express = require('express');
var app = express();
// concat directories together
var path = require('path');
// form data with post request to use req.body(form key:values)
var bodyParser = require('body-parser');
// use bodyparser to map the form data to req.body
app.use(bodyParser.urlencoded({extended: true}));
// point all static static request to a directory
app.use(express.static(path.join(__dirname, "./static")));
// set up for view engine
// where to look
app.set('views', path.join(__dirname, './views'));
console.log(__dirname);
// what view engine?
app.set('view engine', 'ejs');

require('./routes')(app);

// start the server
app.listen(8000, function(){
  console.log("Listening on port 8000");
}) 