# Hair Salon


#### Salon management app to track stylists and their clients.

#### _By Nathan Fletcher_

* This app uses a one-to-many database to add stylists, view all stylists, and add clients connected to a specific stylist.

## Technologies Used

* MySQL
* Entity Framework Core
* C#
* Object Oriented Programming
* ASP.NET Core MVC

## Setup

<details>
<summary>Setup & Installation Instructions</summary>


#### Installations (if necessary)
* Install C# and .NET using the [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-5.0.100-macos-x64-installer)
* Install [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914)
* Install [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391)

#### Setup
* Clone this repository to your local machine
* Navigate to the HairSalon.Solution create a file named "appsettings.json" 
* Add the following code to the file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=nathan_fletcher;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
* Navigate to the HairSalon folder and run the following commands:
* `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
* `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
* `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`

#### Import the database
* Run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your own MySql password
* Open MySql Workbench
* Select your preferred server(default is root)
* In the "Navigator > Administration" window, select "Data Import/ Restore"
* In "Import Options", select "Import From Self-Contained File"
* Navigate to "HairSalon.Solutions/nathan_fletcher.sql" in the search input
* Under "Default Schema to be Imported to" select the "New" button
* Enter "nathan_fletcher" and click "OK"
* Navigate to the "Import Progress" tab and click "Start Import" in the bottom right corner of the window
* Reopen the "Navigator>Schemas" tab, Right click and select "refresh all" to see the imported database

#### Start
* From the terminal in the HairSalon folder, run the following commands:
* `dotnet restore`
* `dotnet build` to compile the project.
* `dotnet run` to start the server.
* Enter localhost:5000 in your browser to start using the app. 
</details>

## Known Issues
* There are no known issues at this time.
* Please contact me if you find any bugs or have suggestions. 

## Future Plans
* Add Search functionality.

## License

_[MIT](https://opensource.org/licenses/MIT)_  

Copyright (c) 2021 Nathan Fletcher 

## Contact Information

_Nathan Fletcher @ github.com/nathanfletch_  