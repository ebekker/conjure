
# NOTES - Research Samples

## `BlazorServerAuth`

A stock Blazor Server app with _Individual_ authentication added.

Created with:

```pwsh
PS> dotnet new blazorserver --auth Individual

PS> dotnet tool install -g dotnet-aspnet-codegenerator
    ### OR ###
PS> dotnet tool update -g dotnet-aspnet-codegenerator
    ### OR ###
PS> dotnet tool update -g dotnet-aspnet-codegenerator --version 6.0.0-preview.7.21413.1
```

Scaffolding ASP.NET Identity pages is detailed
[here](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-5.0&tabs=netcore-cli#scaffold-identity-into-a-blazor-server-project-with-authorization).

Updated with:

```pwsh
PS> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --prerelease
PS> dotnet add package Microsoft.EntityFrameworkCore.Design --prerelease
PS> # dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
PS> # dotnet add package Microsoft.AspNetCore.Identity.UI
PS> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --prerelease
PS> # dotnet add package Microsoft.EntityFrameworkCore.Tools
```
