
# NOTES - Research Samples

## `BlazorServer5Auth`

A stock Blazor Server (net5.0) app with _Individual_ authentication added.

Created with:

```pwsh
PS> dotnet new blazorserver --auth Individual --framework net5.0

PS> dotnet tool install -g dotnet-aspnet-codegenerator
    ### OR ###
PS> dotnet tool update -g dotnet-aspnet-codegenerator
```

Scaffolding ASP.NET Identity pages is detailed
[here](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-5.0&tabs=netcore-cli#scaffold-identity-into-a-blazor-server-project-with-authorization).

Updated with:

```pwsh
PS> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
PS> dotnet add package Microsoft.EntityFrameworkCore.Design
PS> # dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
PS> # dotnet add package Microsoft.AspNetCore.Identity.UI
PS> dotnet add package Microsoft.EntityFrameworkCore.SqlServer
PS> # dotnet add package Microsoft.EntityFrameworkCore.Tools
```

To list all available files to be scaffolded:  `PS> dotnet aspnet-codegenerator identity -lf`


## `BlazorServerAuth`

A stock Blazor Server (net6.0 preview) app with _Individual_ authentication added.

Created with:

```pwsh
PS> dotnet new blazorserver --auth Individual --framework net5.0

PS> dotnet tool install -g dotnet-aspnet-codegenerator
    ### OR ###
PS> dotnet tool update -g dotnet-aspnet-codegenerator
    ### OR ###
PS> dotnet tool update -g dotnet-aspnet-codegenerator --version 6.0.0-preview.7.21413.1
```

Scaffolding ASP.NET Identity pages is detailed
[here](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-6.0&tabs=netcore-cli#scaffold-identity-into-a-blazor-server-project-with-authorization).

Updated with:

```pwsh
PS> dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --prerelease
PS> dotnet add package Microsoft.EntityFrameworkCore.Design --prerelease
PS> # dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
PS> # dotnet add package Microsoft.AspNetCore.Identity.UI
PS> dotnet add package Microsoft.EntityFrameworkCore.SqlServer --prerelease
PS> # dotnet add package Microsoft.EntityFrameworkCore.Tools
```

To list all available files to be scaffolded:  `PS> dotnet aspnet-codegenerator identity -lf`
