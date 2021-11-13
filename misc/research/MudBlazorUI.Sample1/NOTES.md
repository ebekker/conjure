# NOTES

## Adding EFX CLI tooling

```pwsh
PS> dotnet new tool-manifest
PS> dotnet tool install --local --add-source ..\..\..\src\Conjure.EFX.DotNetTool\nupkg Conjure.EFX.DotNetTool
## If you rebuild the EFX tool
PS> dotnet tool update  --local --add-source ..\..\..\src\Conjure.EFX.DotNetTool\nupkg Conjure.EFX.DotNetTool
```
