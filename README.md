# COP4710

Final Project for Database Design

To properly run our application a few steps need to be taken:

Step 1: Within the directory there is a file named "CONNSTRING.txt", an example is shown below with the database and password needing to be filled in. Be sure to fill it out correctly with your psql information other wise the application will not work.

Server=localhost;Port=5432;Database=(FILLIN);User Id=postgres;Password=(FILL IN)

Step 2: Within the database you filled out above you will need to create 3 tables. The sql code for this is displayed below (build in order):

CREATE TABLE Game(
game_id SERIAL PRIMARY KEY,
game_name VARCHAR(50),
genre VARCHAR (30),
price NUMERIC(4,2),
company VARCHAR(30),
platform VARCHAR(30),
splashart VARCHAR(255)
);

CREATE TABLE Account(
username VARCHAR(15) PRIMARY KEY,
password CHAR(12),
email VARCHAR(30),
dob DATE,
age INTEGER,
u_type VARCHAR(10),
profilepic VARCHAR(255)
);

CREATE TABLE Review(
review_id SERIAL PRIMARY KEY,
username VARCHAR(15),
game_id SERIAL,
rating INTEGER CHECK (rating >= 1 AND rating <= 5),
description VARCHAR(300),
FOREIGN KEY (username) REFERENCES Account(username),
FOREIGN KEY (game_id) REFERENCES Game(game_id)
);

Step 3: When you create an account be sure to make it an Admin account, you will be prompted to choose between user or admin on the account creator screen. This way you will see all the features our application contains. Predominantly the abilty to Insert, Update, and Delete games via the games list page.

Step 4: To help with testing out the customization features of our app there is a resources folder: (COP4710\TKM Game Hunter\Resources\) that contains some pictures for the profile page, and some splasharts for example games you could add.

Step 5: We utilized Npgsql as a reference in visual studio so that may need to be added if it does not carry over.

Step 6: This project is viewable on GitHub via the link: https://github.com/tlaham/COP4710
