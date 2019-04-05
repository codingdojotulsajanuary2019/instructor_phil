module.exports = {
    show: function(req, res){
        res.render('show')
      },
      create: function(req, res) {
        console.log(req.body);
        res.redirect('/');
      }
}