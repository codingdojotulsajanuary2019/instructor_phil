const express = require('express')
const app = express();
const path = require('path');

app.use(express.static(path.join(__dirname, './public/dist/public')));

app.all("*", (req,res,next) => {
    console.log('in catch all route');
    res.sendFile(path.resolve("./public/dist/public/index.html"))
});

app.listen(8888,()=>console.log('listening on port 8888'));