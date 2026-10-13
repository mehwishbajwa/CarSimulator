# G1 – Comparing Different Versions of Source Code

## Project Information

**Project:** CarSimulator  
**Repository:** https://github.com/mehwishbajwa/CarSimulator  
**File:** `DataLogicLibrary/Services/SimulationLogicService.cs`  
**Commit:** `f5741c0`  
**Commit link:** https://github.com/mehwishbajwa/CarSimulator/commit/f5741c0

## Objective

The objective of this task is to demonstrate how Git and GitHub can be used to compare different versions of a source code file and understand the changes made during development.

## Changes Made

 1. Code Formatting Improvements

Some long code statements, including the `DirectionStrategyResolver` delegate and the constructor, were divided into multiple lines.

These changes improve readability and make the code easier to maintain.

2. Changes to Simulation Logic

In the `PerformAction()` method, the following code was removed:

```csharp
if (userInput == 6)
    return currentStatus;
```

Previously, the method immediately returned the current status when the user selected option 6.

Removing this early return allows the input to continue to the switch statement, where different simulation actions are handled.

3. Comparing Versions Using GitHub

GitHub provides a visual comparison between the previous and updated versions of the source code.

- Red lines indicate removed code.
- Green lines indicate added code.
- Unchanged lines provide context.

This makes it easier to identify modifications, review code, and understand the development history.

## Evidence

Commit comparison:

https://github.com/mehwishbajwa/CarSimulator/commit/f5741c0

The commit history and code comparison demonstrate how the source code has changed over time.

## Conclusion

Through this task, I demonstrated how to compare different versions of a source code file using GitHub.

Version control helps developers track modifications, understand changes, review code, and maintain a clear history of the project.
