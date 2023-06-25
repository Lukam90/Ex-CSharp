**Create**

dotnet new blazorserver -o ServerCRUD --no-https -f net6.0

dotnet new webapi -o EF6SQLite --no-https -f net6.0

**Tools**

dotnet tool install --global dotnet-ef

**Packages**

dotnet add package Microsoft.EntityFrameworkCore.InMemory