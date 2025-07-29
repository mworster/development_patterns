# Design Patterns Demo

This project demonstrates the implementation of several standard design patterns in C# using .NET 8. The code is written in C# 12.0 and showcases the following design patterns:

## Design Patterns Implemented

### 1. Singleton Pattern
The Singleton pattern ensures that a class has only one instance and provides a global point of access to it.

- **Class**: `Singleton`
- **Usage**: Demonstrates how to create and access a single instance of a class.

### 2. Factory Pattern
The Factory pattern provides a way to create objects without specifying their exact class.

- **Interface**: `IProduct`
- **Classes**: `ConcreteProductA`, `ConcreteProductB`
- **Factory**: `ProductFactory`
- **Usage**: Demonstrates how to create objects of different types (`ConcreteProductA` and `ConcreteProductB`) using a factory method.

### 3. Strategy Pattern
The Strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.

- **Interface**: `IStrategy`
- **Classes**: `StrategyA`, `StrategyB`
- **Context**: `Context`
- **Usage**: Demonstrates how to switch between different strategies (`StrategyA` and `StrategyB`) at runtime.

### 4. Observer Pattern
The Observer pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified.

- **Interface**: `IObserver`
- **Classes**: `ConcreteObserver`, `Subject`
- **Usage**: Demonstrates how observers (`ConcreteObserver`) can subscribe to and receive updates from a subject (`Subject`).

## How to Run

1. Ensure you have the .NET 8 SDK installed.
2. Clone the repository or copy the code into a `.cs` file.
3. Open the project in Visual Studio or your preferred IDE.
4. Build and run the project.
5. Observe the output in the console, which demonstrates the behavior of each design pattern.

## Example Output

When you run the program, you will see output similar to the following:

