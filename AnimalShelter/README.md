# _Animal Shelter_

#### _An API that allows you to cread, read, update, and delete animal object from a shelter databasse, 04/03/2020_

#### By _**Patrick Delaney**_

## Description

_Using this API, you can create/edit your own animal shelter! At the moment, the only species are dogs and cats. Feel free to add more! You have the ability to edit, create, observe, and delete objects in the database through this API._

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

## Documentation
_ To view documentation for this API, use the following links to view the documentation produced by Swagger. Version 1.0:(https://app.swaggerhub.com/apis/PatterCat666/animal-shelter/0.1), version 2.0: (https://app.swaggerhub.com/apis/PatterCat666/animal-shelter/0.2)._

## Versioning
_ There are two versions of this API. Version two has all of the same endpoints at version one, with the addition of age parameters. In version two, you may enter an exact age for an animal; or you may enter a range(ex. ages: 2-20). You indicate which version you're using within the URL of the API call.(/api/{api version}/animals). _
## Endpoints and making requests
HTTP Request Routes
REQUEST: CRUD/api/{api version(1-2)}/animals/{id}
REQUEST: CRUD/api/{api version(1-2)}/animals/?parameter

GET /api/{version}/animals
* Get a list of all animals.

GET /api/{version}/animals/{id}
* Get a specific animal via it's ID from the database.

POST /api/{version}/animals
* Post an animal to the database.

PUT /api/{version}/animals/{id}
* Edit a specific animal from the database.

DELETE /api/{version}/animals/{id}
* Delete a specific animal from the database.

_Version One Parameters:_
| Parameter | Type | Description |
| :---: | :---: | :---: | --- |
| name | string | Query animal by name. |
| species | string | Query animal by species. |
| gender | string | Query animal by gender. |
| age | int | Query animal by age. |

_Additional parameters using Version Two:_
| Parameter | Type | Description |
| :---: | :---: | :---: | --- |
| start | int | Query animal by age older than this number. |
| age | int | Query animal by age. |
| end | int | Query animal by age younger than this number. |


Example Queries:
http://localhost:5000/api/1/animals/?species=dog
http://localhost:5000/api/2/animals/?parameter
http://localhost:5000/api/1/animals/?parameter1&parameter2

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

_At the moment, even though you can search for a specific age in version 2.0 of the API (AnimalsTwoController), when you try to request animals within a range of ages (http://localhost:5000/api/2.0/animals/age/?start=01-01-2012&end=01-31-2019), you get the following error:_
`{`
    `"errors": {`
        `"id": [`
            `"The value 'age' is not valid."`
        `]`
    `},`
    `"title": "One or more validation errors occurred.",`
    `"status": 400,`
    `"traceId": "0HLUO4T0R5API:00000006"`
`}`

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
