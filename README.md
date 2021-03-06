# "Treat Urself"

#### _Basic user-authorization implementation with ASP.NET Identity and MySQL_ | Patrick Lee

## Description

This project was made to demonstrate basic proficiency in the usage of ASP.NET's Identity framework for user registration, authentication, and authorization while working with MySQL databases in an ASP.NET Core MVC web application. Pierre, the fictitious baker, is back. This time, he wants a solution for visitors to view a many-Treats-to-many-Flavors database relationship, as well us create, update, and delete data only if they are registered, logged-in users.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these pinned installation instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
- A web browser to view and interact with the project

### Installation

1. Clone the repository: `$ git clone https://github.com/patrick-verbs/TreatUrself.Solution`
2. Navigate to the `TreatUrself.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup the SQL database using MySQL:
   - You ___do not___ need to create an `appsettings.json` file manually; the program will check for this file on startup, and create the file for you based on prompts
   - If you opt to create `appsettings.json` manually:
      - Create an `appsettings.json` file in the `TreatUrself` directory
      - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
      ```
      {
         "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=patrick_lee;uid=root;pwd=<password>;"
            }
      }
      ```
      - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) to launch MySQL server
5. To serve the local web app:
   - Navigate to `TreatUrself.Solution/TreatUrself` in your command line
   - Run the commands:
     - `dotnet restore` to restore the dependencies that are listed in `TreatUrself.csproj`
     - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
     - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
     - `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
     - `dotnet build` to build the project and its dependencies into a set of binaries
     - `dotnet tool install --global dotnet-ef` to install EF Core tools
     - `dotnet ef database update` to build the MySQL database
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`

## Known Bugs

_No known bugs_ :bug:

## Technologies Used

- This terrific [.NET Core MVC + MySQL template](https://github.com/TorchAblaze/TreatUrself.Solution) by __[TorchAblaze](https://github.com/TorchAblaze)__
- MySQL Server 8.0.19 and MySQL Workbench 8.0.19
- C#
- .NET 5 SDK
- ASP.NET Core MVC with Identity
- Entity Framework Core
- HTML5 with Razor syntax
- CSS3 with Bootstrap 4.5.0 framework
- VS Code

### License

<details>
<summary><a href="https://opensource.org/licenses/MIT"><strong>MIT</strong></a></summary>
<pre>
MIT License

Copyright (c) 2021 Patrick Lee

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

</pre>
</details>

Copyright ?? 2021 Patrick Lee