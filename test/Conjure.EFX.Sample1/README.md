
# README

```pwsh
## Prep the tool manifest
dotnet new tool-manifest

## Install the EFX tool
## (Had to clear local nuget caches to make tool install work -- WHY????)
nuget locals all -clear
dotnet tool install --add-source ../../src/Conjure.EFX.DotNetTool/nupkg Conjure.EFX.DotNetTool

## Run the tool
dotnet tool run efx -- --help

## Restore
dotnet tool restore --add-source ../../src/Conjure.EFX.DotNetTool/nupkg Conjure.EFX.DotNetTool

## Update
dotnet tool update --add-source ../../src/Conjure.EFX.DotNetTool/nupkg Conjure.EFX.DotNetTool
```
