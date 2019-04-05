const controller = require('./controller');

module.exports = function(app){

   // setting routes for incoming url's
    app.get('/show', controller.show)
    app.post('/users', controller.create)
}


// routes
