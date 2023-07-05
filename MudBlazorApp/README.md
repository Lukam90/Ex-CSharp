# MudBlazorApp

**Commands**

dotnet new mudblazor -o MudBlazorApp --host server --name MudBlazorApp

**Packages**

dotnet add package Microsoft.EntityFrameworkCore<br>
dotnet add package Microsoft.EntityFrameworkCore.Design<br>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite

dotnet add package Swashbuckle.AspNetCore

**Database**

dotnet ef migrations add AddedSupplierTable

dotnet ef database update