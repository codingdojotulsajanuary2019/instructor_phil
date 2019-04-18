const mongoose = require('mongoose');
const Record = mongoose.model('Record');

module.exports = {
    index: (req, res)=>{
        Record.find()
        .then(records => res.json({status: true, records: records}))
        .catch(err => res.json({status: false, err:err}))
    },
    show: (req, res)=>{
        const record_id = req.params.id;
        Record.findOneById(record_id)
        .then(record => res.json({status: true, record: record}))
        .catch(err => res.json({status: false, err:err}))
    },
    create: (req, res)=>{
        Record.create(req.body)
        .then(record => res.json({status: true, record: record}))
        .catch(err => res.json({status: false, err:err}))
    },
    update: (req, res)=>{
        const record_id = req.params.id;
        Record.findOneById(record_id)
        .then(record => {
            record.artist = req.body.artist;
            record.title = req.body.title;
            record.date = req.body.date;
            record.save()
            .then(record => res.json({status: true, record: record}))
            .catch(err => res.json({status: false, err:err}))
        })
        .catch(err => res.json({status: false, err:err}))
    },
    delete: (req, res)=>{
        const record_id = req.params.id;
        Record.findByIdAndDelete(record_id)
        .then(record => res.json({status: true}))
            .catch(err => res.json({status: false}))
    },
}