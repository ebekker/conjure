
# README - Conjure EFX Tool

The Conjure EFX tool is used to refresh the local cache of metadata
for data sources for which you wish to generate scaffolded code.

## Installation

The tool can be installed as either a global or local tool.

### Install as a Global Tool

The tool can be installed globally:

```pwsh
## To install from NuGet.org
dotnet tool install --global Conjure.EFX.DotNetTool

## To install from some alternate location, such as a local path
dotnet tool install --global --add-source \<file-path-or-url> Conjure.EFX.DotNetTool
```

Then invoke it globally:

```pwsh
efx --help
```

### Install as a Local Tool

The tool can be installed locally within a project or solution:

```pwsh
## If you don't already have a tool manifest within your solution or project
dotnet new tool-manifest

## Add the tool to the manifest from NuGet.org
dotnet tool install Conjure.EFX.DotNetTool

## To install from some alternate location, such as a local path
dotnet tool install --add-source \<file-path-or-url> Conjure.EFX.DotNetTool
```

If you are pulling a project or solution created by others, you need to restore the tool added by others:

```pwsh
dotnet tool restore
```

Once the tool is installed or restored, then you can invoke it
locally from the manifest directory or any _child_ directories:

```pwsh
dotnet tool run efx --help
```

## Usage

The tool is used to resolve any local EFX profiles in your project's root path and generate
a cache of data source metadata. The data source meta data is then used to generate code using a
companion Roslyn Source Generator.

An EFX profile is identified as directories ending with the extension suffixe `.efx`, for
example `sample1.efx`. It must also contain at least one file named `_efx.yaml` which defines the
profile options, such as data source connection information and data source provider type.

The profile options are also used to tailor the source generation behavior, as including or
excluding different data source artifacts or what features the generated source should include.

Additionally, you can override the default source generation templates by including your own
template files in the profile directory.

You can get details about the arguments and options for command line invocation of the tool:

```pwsh
efx --help
```
