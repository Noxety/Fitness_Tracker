# Fitness Tracker Software

## Overview

This Fitness Tracker software is a comprehensive application designed to help users monitor their fitness goals, track progress, and maintain a healthy lifestyle. Built using C# .NET, it connects seamlessly with a MySQL database.

## Features

- User registration and login
- Goal setting (e.g., weight, calorie intake, exercise routines)
- Progress tracking with visual charts
- Integration with MySQL for data storage
- User-friendly interface

## Getting Started

Follow the instructions below to set up and run the Fitness Tracker software on your local machine.

### Prerequisites

- **Visual Studio**: Ensure that Visual Studio is installed with the .NET desktop development workload.
- **MySQL Database**: Install and set up MySQL on your system.
- **MySQL Connector**: Install the MySQL Connector for .NET to enable communication between the application and the database.

### Installation

1. Clone the repository:
   ```sh
   git clone <repository-url>
Open the solution file:
Navigate to the project folder and locate the fitness_T.sln file.
Double-click the fitness_T.sln file to open the project in Visual Studio.
Database Setup
Create a MySQL database for the application. For example:

SQL
CREATE DATABASE fitness;
Import the database schema:

Locate the SQL script file (schema.sql) in the project repository.
Use a MySQL client or command line to run the script:
sh
mysql -u <username> -p fitness < schema.sql
Update the database connection string:

Open the appsettings.json file in the project.
Update the connection string with your MySQL credentials:
JSON
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=fitness;User ID=<username>;Password=<password>;"
}
Running the Application
Set the startup project in Visual Studio:

Right-click the solution in the Solution Explorer.
Select "Set Startup Project" and choose the appropriate project.
Build the solution:

Go to Build > Build Solution or press Ctrl+Shift+B.
Run the application:

Press F5 or click the Start button in the toolbar.
Troubleshooting
Ensure that MySQL is running on your machine.
Verify that the connection string matches your database credentials.
Check for missing NuGet packages and restore them by going to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.
Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

License
This project is licensed under the MIT License. See the LICENSE file for details.

Contact
For further assistance or inquiries, please contact:

Email: thura3.shine33@gmail.com
GitHub: Noxety
