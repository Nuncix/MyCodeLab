# C#

C# exercises covering object-oriented programming, collections, recursion,
small domain models, and desktop interfaces.

## Contents

- Numbered folders contain independent exercises, including counters, polynomial
  operations, time calculations, address books, races, and other small applications.
- Several exercises include Windows Forms interfaces and `.dia` diagrams.
- [LinqExamples](LinqExamples/) contains a .NET 6 console project for LINQ examples.

## Running the Projects

From this folder, run the LINQ example with a compatible .NET SDK:

```sh
dotnet run --project LinqExamples/LinqExamples.csproj
```

The numbered exercises contain older Visual Studio solutions and .NET Framework
projects. Open the relevant `.sln` in Visual Studio on Windows and install the
targeting pack required by its project. Windows Forms projects cannot run natively
on Linux or macOS. Each solution is independent; there is no shared build command.

Build output and personal Visual Studio settings are ignored. Keep project files,
designer sources, resources, and diagrams in version control.
