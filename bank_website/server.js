'use strict';
var fs = require('fs');
var path = require('path');
var express = require('express');
var bodyParser = require('body-parser');
var app = express();

var dotenv = require('dotenv');
dotenv.config();

app.use(bodyParser.json());
const mysql = require('mysql2');

const con = mysql.createConnection({
    host: process.env.DATABASE_HOST,
    user: process.env.DATABASE_USER,
    password: process.env.DATABASE_PASSWORD,
    database: process.env.DATABASE_NAME
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
    console.log('Server started: http://localhost:' + app.get('port') + '/Front-End/Home.html');
});