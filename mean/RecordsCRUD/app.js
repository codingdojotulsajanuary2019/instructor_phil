const express = require('express');
const path = require('path');
const bodyParser = require('body-parser');
const port = 8888;
const app = express();

app.use(express.static(path.join(__dirname, './public/dist/public')));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended:true}));

require('./server/config/mongoose');
require('./server/config/routes')(app);

app.listen(port, ()=> console.log(`Listening on port: ${port}!`));