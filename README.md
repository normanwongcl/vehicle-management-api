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

### All design decision can be found in documentation link below

[Documentation]()

## Install

```bash
# Clone repository
git clone git@github.com:normanwongcl/vehicle-management-api.git

# Restore dependencies
dotnet restore

```

## Set up a test database

1. Open Visual Studio 2019
2. Go to `View` > `SQL Server Object Explorer`
3. Drilldown to `SQL Server` > `(localdb)\MSSQLLocalDB`
4. Right-click "`Database`" Folder
5. Click "`Add New Database`"
6. Name it as "`TestDB`" and click OK
7. Right-click on the "`TestDB`" database and then select "`New Query`"
8. Run this [sql script](TestDB.sql)

## Test

Run test by using the dotnet cli or in Visual Studio 2019

```

dotnet test

```

## Deployment

```

# TODO

```

```

```
