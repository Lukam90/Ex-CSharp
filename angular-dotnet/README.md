# angular-dotnet

[CRUD with Angular 14 & .NET 6 🚀 Web API, EF Core & SQL Server](https://www.youtube.com/watch?v=dtthbiP3SE0) de *Patrick God*

## superheroes-app

**Create**

ng new SuperHeroUI

**Run**

ng serve -o

**Services**

ng g s super-hero --skip-tests

## SuperHeroAPI

**Create**

dotnet new webapi -o SuperHeroAPI --no-https -f net7.0

**Run**

dotnet watch

**Packages**

dotnet add package Microsoft.EntityFrameworkCore<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

**Migrations**

dotnet ef migrations add Initial

dotnet ef database update




















