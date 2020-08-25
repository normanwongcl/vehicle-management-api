# Vehicle Management API

Vehicle Management API build using [ApiBoilerPlate.AspNetCore](https://github.com/proudmonkey/ApiBoilerPlate) project template.

## Prerequisite

```yaml
.NET Core SDK: 3.1 or higher
.NET Core runtime:
  Microsoft.AspNetCore.App: 3.1.7 or higher
  Microsoft.NETCore.App: 3.1.7 or higher
```

## Prerequisite install

Installation instructions for anyone using WSL Ubuntu can be found in this [guide](https://ubuntu.com/blog/creating-cross-platform-applications-with-net-on-ubuntu-on-wsl)

Installation for other OS can be found in the documentation link below:

[Windows](https://docs.microsoft.com/en-us/dotnet/core/install/windows?tabs=netcore31)
[macOS](https://docs.microsoft.com/en-us/dotnet/core/install/macos)
[Linux](https://docs.microsoft.com/en-us/dotnet/core/install/linux)

## Tooling Decision

### Why .NET Core?

According to [Thoughtwork](https://www.thoughtworks.com/radar/platforms/net-core), .NET core should be the default for building .NET project.

### Why ApiBoilerPlate.AspNetCore boilerplate?

The boilerplate was used to help me quickly scalfold a solution since I went from learning C# syntax, to learning Object-oriented programming, to learning the differences between abstract class / interface (contract), to learning to design a REST API in a few days.

The boilerplate helps me understand how people set up a logger, CORS, Unit Tests, Model/Entity, Controller, api documentation, etc for ASP.NET.

## Editor

If you are using VSCode, install the following extension:

```yaml
C#: 1.23.0 or higher
vscode-solution-explorer: 0.3.0 or higher
k--kato.docomment: 0.1.18 or higher
```

## Install

```bash
# Clone repository
git clone git@github.com:normanwongcl/vehicle-management-api.git

# Restore dependencies
dotnet restore

# Run project
TODO
```

## Test

Run test by using the dotnet cli

```
dotnet test
```

## Deployment

```
# TODO
```
