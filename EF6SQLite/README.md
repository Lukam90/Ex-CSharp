# EF6SQLite

[.NET 6 🚀 EF Core & SQLite with Code First Migrations](https://www.youtube.com/watch?v=PDiRDNNc2tw)

**Create**

dotnet new webapi -o EF6SQLite --no-https -f net6.0

**Tools**

dotnet tool install --global dotnet-ef

**Packages**

dotnet add package Microsoft.EntityFrameworkCore<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Swashbuckle.AspNetCore

**Migrations**

dotnet ef migrations add Initial

dotnet ef database update