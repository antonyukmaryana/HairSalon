# HairSalon.Solution


#### MVC web application for a hair salon. The owner should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist. 5/12/19

#### By **Maryana Antonyuk**

## Description
Hair Salon
 MVC web application for a hair salon. The owner should be able to add a list of the stylists, and for each stylist, add clients who see that stylist. The stylists work independently, so each client only belongs to a single stylist.

User Stories
Here are the user stories that your app should already fulfill:

As a salon employee, I need to be able to see a list of all our stylists.
As an employee, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
As an employee, I need to add new stylists to our system when they are hired.
As an employee, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.
And here are the user stories that the salon owner would like you to add:

As an employee, I need to be able to delete stylists (all and single).
As an employee, I need to be able to delete clients (all and single).
As an employee, I need to be able to view clients (all and single).
As an employee, I need to be able to edit JUST the name of a stylist. (You can choose to allow employees to edit additional properties but it is not required.)
As an employee, I need to be able to edit ALL of the information for a client.
As an employee, I need to be able to add a specialty and view all specialties that have been added.
As an employee, I need to be able to add a specialty to a stylist.
As an employee, I need to be able to click on a specialty and see all of the stylists that have that specialty.
As an employee, I need to see the stylist's specialties on the stylist's details page.
As an employee, I need to be able to add a stylist to a specialty.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Homepage** |  | Homepage with Welcome and link to a form|
| **Program takes to a page with a form** | User Input: word and sentence(word, phrase, sentence) and pressing "Submit" button  | Output: Inputted Word, Inputted sentence and number of matches and a link to play another game.
| **Program takes to a form page**| Input: User Input: word and sentence(word, phrase, sentence), and press "Submit" button   | Output: The result of the previous and current game. Link to play a new game. |


## Setup/Installation Requirements

1. To run this program, you must have any Internet browser installed. I use [Chrome](https://www.google.com/chrome/?brand=CHBD&gclid=Cj0KCQjwtMvlBRDmARIsAEoQ8zTDauh_W6y-Cpg5m7HlexhAgOV4olX-i6Lvp3uFLKp6umCRq_5j3D0aAviGEALw_wcB&gclsrc=aw.ds).
2. Clone this repository.
3. Open Mac Terminal or Windows Command Prompt.
4. Type "cd HairSalon.Solution" and press enter to go to the solution directory.
5. Type "cd HairSalon.Solution" and press enter to go to the application directory.

  D:\user\ProjectName.Solution\ProjectName>dotnet restore
  D:\user\ProjectName.Solution\ProjectName>dotnet build
  D:\user\ProjectName.Solution\ProjectName>dotnet run
  Hosting environment: Production
  Content root path: D:\user\ProjectName.Solution\ProjectName
  Now listening on: http://localhost:5000
  Application started. Press Ctrl+C to shut down.

6. Open a web browser and go to http://localhost:5000/*

In MySQL:
-Download and install MAMP
- Run MAMP
- For main database
    - In MySql:
        > CREATE DATABASE maryana_antonyuk;
        > USE maryana_antonyuk;
        > CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
        > CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT(11));
- For test database
    - In MySql:
        > CREATE DATABASE maryana_antonyuk_test;
        > USE maryana_antonyuk_test;
        > CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
        > CREATE TABLE clients (id serial PRIMARY KEY, name VARCHAR(255), stylist_id INT(11));
$ cd ~/HairSalon.Solution/HairSalon
$ dotnet restore
$ dotnet run

Open your browser to localhost:5000


## Known Bugs
* No known bugs at the time.

## Technologies Used
* C#
* ASP.NET Core MVC


## Support and contact details

_Email me with any questions, comments, or concerns._

### License

*This software is licensed under the MIT license*

Copyright (c) 2019 **_Maryana Antonyuk_**
