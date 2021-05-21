# _Clair's Cuts_
#### _This is our 10th week project for Epicodus that covers the basics for One-to-Many relationships and MySql._
#### By _Jesse White_
## Technologies Used
* _CSHTML_ 📝
* _CSS_ 🎨
* _C#_ 🆒
* _.NET_ 🥅
* _MySql_ 💽
## Description 📜
_Claire runs a local Hair Salon where you can get qualitiy cuts from. Claire uses this web application to manage their stylists on staff and the clients they have._
## Setup and Use 🏗

### Prerequisites 💻

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.
- [MySQL Community Server][https://dev.mysql.com/downloads/file/?id=484914]

### Installation

1. Clone the repository: `$ git clone {https://github.com/JesseDWhite/HairSalon.Solution}`
2. Navigate to the `{HairSalon.Solution}` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `{HairSalon}` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=jesse_white;uid=root;pwd=<password>;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and select the enter key to launch MySQL servers
   - Type the following commands to setup the database:
     - `CREATE DATABASE jesse_white;` to make a new database
     - `USE jesse_white;` to connect to the new database
     - `CREATE TABLE {clients (ClientId INT, SomeProperty VARCHAR (255))};` to create a `{clients}` table
     - `CREATE TABLE {stylists (TemplateItemId INT, TemplateCategoryId Int)};` to create another new `{stylists}` table
5. To run the console app:
   - Navigate to `{HairSalon.Solution/HairSalon}` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `{HairSalon.csproj}`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
   - Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`
## Known Bugs 🐛
* _Any known issues_
* _should go here_
## License ⚖
_MIT © Jesse White 2021_
## Contact Information 🤳
Jesse White _jesse.white6@gmail.com_