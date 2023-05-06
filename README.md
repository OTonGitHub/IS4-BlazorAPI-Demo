# Notes & Configuration
<h3>Project URLs and Ports</h3>
Server:</br>
    - 5550 (https)</br>
    - 5000</br>
API :</br>
    - 5552 (https)</br>
    - 5002</br>
Client:</br>
    - 5554 (https)</br>
    - 5004</br>
<h3>Running in VSCode</h3>
<ul>
    <li>ctrl + shift + p in root, .NET: Generate Assets for Build and Debug</li>
</ul>
<h3>Dotnet Commands</h3>
<h2>Solution Setup</h2>
<ul>
    <li><em>dotnet new web -lang "c# -n "API" -f "net6.0" -o .\API -d -v diag</em> (empty ASP.NET Web Project)</li>
    <li><em>dotnet new classlib -lang c# -n DataAccess -f net6.0 -o .\DataAccess -d -v diag</em> (.NET 6 Class Lib)</li>
    <li><em>dotnet add API/API.csproj reference DataAccess/DataAccess.csproj</li>
</ul>
<h2>Adding Dependencies</h2>
- Nuget Gallery .NET CLi
<ul>
    <li><em>dotnet add API/API.csproj package Microsoft.EntityFrameworkCore.SqlServer</li>
    <li><em>dotnet add API/API.csproj package Microsoft.EntityFrameworkCore.Tools</li>
    <li><em>dotnet add DataAccess/DataAccess.csproj package Microsoft.EntityFrameworkCore.SqlServer</li>
    <li><em>dotnet add DataAccess/DataAccess.csproj package Microsoft.EntityFrameworkCore.Tools</li>
</ul>