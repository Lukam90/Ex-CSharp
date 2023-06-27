# MvcMovie

**Create**

dotnet new mvc -o BookApp --no-https

**HTTPS**

dotnet dev-certs https --trust

**Serve**

dotnet watch

**Export**

export PATH=$HOME/.dotnet/tools:$PATH

**Packages**

dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

**Migrations**

dotnet ef migrations add InitialCreate

dotnet ef database update