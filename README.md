# Pierre's Treats Application 

#### MVC web application to manage a bakery's products!

## Authored by: 

Noah Cowan, April 2023

***

## Description:

This is an API written in C#. The user can access the API through an API platform such as Swagger (browser-based), or POSTman (standalone). Upon running the API, the user can view, post, edit, and delete entries from a linked database containing a list of US national parks. The items in the list are also searchable by specific data-point.
***

## Technologies Used

- C#
- .NET
- ASP.NET Core
- Entity Framework Core
- MySQL Workbench
- Git
- Github
- Markdown
- Swashbuckle
- Swagger
***

## Setup/Installation Requirements

### Installation Steps
1. Install a compatible version of .NET 6. An installation link can be found [here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).
2. In the terminal, install dotnet-script by runing the following command
```bash
$ dotnet tool install -g dotnet-script
```
3. Configure your local environment to use this. Instructions [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script).
4. Then, install MySQL. Instructions [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

### Repository Setup
1. Clone this repository.
2. Open your terminal and navigate to this project's production directory called "ParksLookupApi".
3. Within the ParksLookupApi directory, create a file titled appsettings.json
4. Open your file editor and navigate to appsettings.json
5. In the appsettings.json file, paste the following code:
```javascript
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=noah_cowan;uid=[uid];pwd=[pwd];"
  }
}
```
6. Replace [uid] and [pwd] with your created SQL username and password respectively (excluding the braces).

### Create the Database with Entity Framework Migrations
<!-- 1. Open your terminal to your local root directory and install ef migrations: 
  run: "dotnet tool install --global dotnet-ef --version 6.0.0"
2. In the project directory, run the following command to install Entity Framework Core Design:
  "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"
3. In the same directory, run the following command to install AspNetCore Identity:
  "dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0" -->
4. `$ dotnet ef database update`

### Execute the Program
1. Open the terminal and navigate to the production directory titled Storefront.
2. Run `dotnet watch run` in the command line.

### Endpoints


## Known Bugs
None
***

## License

_MIT License

Copyright (c) [2023] [Noah Cowan]

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._