# _Animal Shelter_

#### _An API that allows you to cread, read, update, and delete animal object from a shelter databasse, 04/03/2020_

#### By _**Patrick Delaney**_

## Description

_Using this API, you can create/edit your own animal shelter! At the moment, the only species are dogs and cats. Feel free to add more! You have the ability to edit, create, observe, and delete objects in the databse through this API._

## Specs

* Behavior: User is able to view objects within the database.
  * Input: "API call to view object(s) within the database."
  * Output: *Requested object(s) are returned to the user from the databse*

* Behavior: An object will be added to a databse through the API.
	* Input: "Create an animal object."
	* Output: *Object is stored in the database for future reference.*

* Behavior: An object will be deleted from the database using the API.
  * Input: "Delete an animal object."
  * Output: *Object is removed from the database through the API.*

* Behavior: User is able to edit objects within the database.
  * Input: "API put request is made to the API containing a body of the edited object"
  * Output: *Object with that id is updated to match the user's put request.*


## Setup/Installation Requirements

* _1. CLone the repository containing the API._
  * Open your command terminal, navigate to the desktop directory and enter the following command: `> git clone https://github.com/Prestwick97/AnimalShelter.Solution.git`.
* _2. After cloning the repository, navigate to the project directory of the repository._
  * `> cd AnimalShelter.Solution`
  * `> cd AnimalShelter`
* _3. Once you're inside the project directory, migrate the data to form a database in MySQL._
  * `> dotnet ef migrations add Initial`
  * `> dotnet ef database update`
  * _You now have the database neccessary to use the API!_
* _Now feel free to C.R.U.D. away using Postman, or by building an interface._

## Known Bugs

_At the moment, there are no known bugs._

## Support and contact details

_If you have any questions, suggestions, comments, or concerns, feel free to contact me at prestwick97@gmail.com_

## Technologies Used

* _C#_
* _.NETcore scaffolding_
* _json_
* _MVC_
* _Postman_
* _API versioning_
* _SwaggerEditer_
* _VScode_
* _MySQL_
* _MySQL Workbench_

### License

*Licensed under the open source MIT license*

Copyright (c) 2020 **_Patrick S. Delaney_**