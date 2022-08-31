# Golf Score Card App

Requirement:
1. Visual Studio 2019 - 2022
2. MSSQL
3. .NET 6+

## Starting the App

In the Golfscorecard.DAL.Data folder there is the DbContext file:

     optionsBuilder.UseSqlServer("Server=[Use own server];Database=GolfScoreDB;Trusted_Connection=True;");

In the case above the default is windows login for mssql.

You may also need to run some migrations. The packages should be installed automatically. To run migrations set the GolfScorecard.DAL project as the starting project as well as switch on the package manager console as well to that particular project. Then run the following:
1.  Add-Migration InitialMigration
2. Update-Database

That should create the necessary DB and tables to get you started.

Switch back to GolfScorecard.UI and run the application (F5)
