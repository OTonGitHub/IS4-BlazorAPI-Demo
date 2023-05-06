# Notes & Configuration
<h2>Project URLs and Ports</h2>
- Server:</br>
<ul>
    <li>5550 (https)</li>
    <li>5000</li>
</ul>
- API :</br>
<ul>
    <li>5552 (https)</li>
    <li>5002</li>
</ul>
- Client:</br>
<ul>
    <li>5554 (https)</li>
    <li>5004</li>
</ul>
<h3>Running in VSCode</h3>
<ul>
    <li>ctrl + shift + p in root, .NET: Generate Assets for Build and Debug</li>
</ul>
<h2>Dotnet Commands</h2>
<h3>Solution Setup</h3>
<ul>
    <li><em>dotnet new web -lang "c# -n "API" -f "net6.0" -o .\API -d -v diag</em> (empty ASP.NET Web Project)</li>
    <li><em>dotnet new classlib -lang c# -n DataAccess -f net6.0 -o .\DataAccess -d -v diag</em> (.NET 6 Class Lib)</li>
    <li><em>dotnet add API/API.csproj reference DataAccess/DataAccess.csproj</li>
</ul>
<h3>Adding Dependencies</h3>
- Nuget Gallery .NET CLI:
<ul>
    <li><em>dotnet add API/API.csproj package Microsoft.EntityFrameworkCore.SqlServer</em></li>
    <li><em>dotnet add API/API.csproj package Microsoft.EntityFrameworkCore.Tools</em></li>
    <li><em>dotnet add DataAccess/DataAccess.csproj package Microsoft.EntityFrameworkCore.SqlServer</em></li>
    <li><em>dotnet add DataAccess/DataAccess.csproj package Microsoft.EntityFrameworkCore.Tools</em></li>
</ul>
- Project References:
<ul>
    <li><em>dotnet add API/API.csproj reference DataAccess/DataAccess.csproj</em></li>
</ul>