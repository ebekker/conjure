
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
```
