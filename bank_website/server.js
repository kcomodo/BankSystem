'use strict';
var fs = require('fs');
var path = require('path');
var express = require('express');
var bodyParser = require('body-parser');
var app = express();

//Configure dotenv to ensure that sensitive information is not uploaded to GitHub
//Also ensure you run "npm install dotenv" in the terminal
var dotenv = require('dotenv');
dotenv.config();

//Now that dotenv in configured, we can access the sensitive information 
//example
var databaseHost = process.env.DATABASE_HOST;

//I have included a file in this commit named ".env.example" that shows how the .env file should be formatted

//Ensure that you create a file named .env in the root of the project and add it to the .gitignore file
//The .env file should contain the following information in this format.

//DATABASE_HOST=istwebclass.org
//DATABASE_USER=fake_database_user
//DATABASE_PASSWORD=fake_database_password
//DATABASE_NAME=fake_database_name


app.use(bodyParser.json());
const mysql = require('mysql2');


//Use the dotenv data for the database connection
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