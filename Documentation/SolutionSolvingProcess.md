# My process for solving this challenge

## Plan out Todolist at the start

:heavy_check_mark: learn how to set up vscode for dotnet core

:heavy_check_mark: learn c# syntax

:heavy_check_mark: relearn object-orieted programming concept

:heavy_check_mark: learn the differences between interface and abstract class

:heavy_check_mark: learn how to design a rest api

:heavy_check_mark: learn how to write tests

:x: learn how to set up CI for dot net core project

:x: learn how to document api

:x: learn to build a cron job console application in dotnet core

## Make a draft for working with Task 1

From relearning OOP, and reading up abstract class and interface, I initially drafted the following design:

```

                 Vehicle

              /           \

         Car             Boat

        /    \
 Hatchback    Sedan

A car “is a” vehicle
A boat “is a” vehicle
A hatchback “is a” car
A sedan “is a” car

Common properties:
- Id
- Make
- Model
- Price

```

## 1st Pseudocode draft

```csharp
// Any class that implements IVehicle must
// define the following properties
namespace DefineIVehicle
{
      using System

      public interface IVehicle
      {
        int Id;
        string Make;
        string Model;
        double Price;
        VehicleType VehicleType;
      }

      class VehicleType {
        int id;
        string typename
      }
}

namespace Vehicle
{
  using System
  using DefineIVehicle

  public abstract class Vehicle: IVehicle
  {
        public Vehicle(string id):
        {

        }

        public string id
        {
            get;
            set;
        }
  }

  public class abstract Car : Vehicle
  {
        public Car(string id) : base(id)
        {
        }

        public abstract int Door;
  }

  public class HatchBack : Car
  {
        public HatchBack(string id) : base(id)
        {
        }

        public override int Door;
  }

  public class Sedan : Car
  {
        public Sedan(string id) : base(id)
        {
        }

        public override int Door;
  }

  public abstract class Boat : Vehicle
  {
        public Boat(string id) : base(id)
        {
        }
  }
}


```

## For learning how to design an API, I had used this [guide](https://medium.com/@factoryhr/how-to-build-a-good-api-relationships-and-endpoints-8b07aa37097c)

[Database Design]()
