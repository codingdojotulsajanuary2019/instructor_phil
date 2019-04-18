const Records = require('./../controllers/records');

module.exports = (app)=>{
    app.get('/api/records', Records.index)
    app.get('/api/records/:id', Records.show)
    app.post('/api/records', Records.create)
    app.put('/api/records/:id', Records.update)
    app.delete('/api/records/:id', Records.delete)
}