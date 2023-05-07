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
<h2>Running in VSCode</h2>
<ul>
    <li>ctrl + shift + p in root, .NET: Generate Assets for Build and Debug</li>
- Extensions:
<ul>
    <li>C# (Omnisharp)</li>
    <li>XML (Red Hat)</li>
</ul>
</ul>
<h2>Dotnet Commands</h2>
<h3>Solution Setup</h3>
<ul>
    <li><em>dotnet new web -lang "c# -n "API" -f "net6.0" -o .\API -d -v diag</em> (empty ASP.NET Web Project)</li>
    <li><em>dotnet new classlib -lang c# -n DataAccess -f net6.0 -o .\DataAccess -d -v diag</em> (.NET 6 Class Lib)</li>
    <li><em>dotnet add API/API.csproj reference DataAccess/DataAccess.csproj</em></li>
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
- On fresh build, run <strong>dotnet restore</strong>, for packages.
<h3>EF Core Migrations</h3>
<ul>
    <li><em>dotnet new tool-manifest</li>
    <li><em>dotnet tool install --local dotnet-ef --version 7.0.5</li>
    <li><em>dotnet ef migrations add CreateRestaurantTable --startup-project API/API.csproj --project DataAccess/DataAccess.csproj --context AppDbContext --verbose</em></li>
    <li><em>dotnet ef database update --project DataAccess/DataAccess.csproj -s API/API.csproj</em></li>
</ul>
<h2>Issues</h2>
<ul>
    <li>has issue with SQL Server self signed ceritificate, currently uses <strong>TrustServerCertificate=True</strong> in connection string to override it</li>
    <li>Unable to set <strong>launchUrl</strong> in launchSettings.json for either kestrel or IIS, may need to look into WebHostBuilder</li>
</ul>
<h2>Notes</h2>
<ul>
    <li>Even though the IRestaurantService is injected and recognized inside the API controller, the implementation is decided in runtime, in order to register the implementation, configure this in the program.cs by adding <strong>builder.services.AddScoped<TService, TImplementation>()</strong>.</li>
    <li>You have to add this just buefore the builder.build()</li>
</ul>