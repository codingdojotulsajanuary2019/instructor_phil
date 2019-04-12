const mongoose = require('mongoose');
const fs = require('fs');
const path = require('path');

mongoose.connect('mongodb://localhost/ninjagold',{ useNewUrlParser: true });

const modelsPath = path.join(__dirname, './../models');

fs.readdirSync(modelsPath).forEach(file => {
    if(file.indexOf('.js')>=0){
        require(modelsPath+'/'+file);
    }
})