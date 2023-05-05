'use strict';
var fs = require('fs');
var path = require('path');
var express = require('express');
var bodyParser = require('body-parser');
var app = express();

app.use(bodyParser.json());
const mysql = require('mysql2');

const con = mysql.createConnection({
    host: "istwebclass.org",
    user: "anewbaue_CatExposure",
    password: "Megumin56",
    database: "anewbaue_Bank"

});

app.set('port', (process.env.PORT || 3000));

app.use('/', express.static(path.join(__dirname, 'public')));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

con.connect(function(err) {
    if (err) throw err;
    console.log("Connected!");
});



app.listen(app.get('port'), function () {
    console.log('Server started: http://localhost:' + app.get('port') + '/frontEnd/homepage.html');
});