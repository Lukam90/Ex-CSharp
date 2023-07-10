# RazorApp

[Razor Pages for ASP.NET Core - Full Course (.NET 6)](https://www.youtube.com/watch?v=eru2emiqow0) de *Bhrugen Patel (FreeCodeCamp)*

**Create**

dotnet new webapp -o RazorApp

**HTTPs**

dotnet dev-certs https --trust

**Run**

dotnet watch

**Packages**

dotnet add package Microsoft.EntityFrameworkCore<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

**Migrations**

dotnet ef migrations add AddCategoryToDatabase

dotnet ef database update