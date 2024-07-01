
# Design Patterns Projects

## Overview
This repository contains three projects demonstrating different design patterns: Iterator Pattern, Command Pattern, and Chain of Responsibility Pattern.

## Projects

### 1. LibraryManagement

**Description:** 
This project demonstrates a library management system using the Iterator Pattern. It allows iteration over a collection of books.

**Project Structure:**
```
LibraryManagement
│
├── Core
│   ├── Entities
│   │   └── Book.cs
│   └── Interfaces
│       └── IIterator.cs
│
├── Application
│   └── Services
│       └── LibraryService.cs
│           └── LibraryIterator.cs
│
└── Presentation
    └── ConsoleApp
        ├── LibraryManagement.csproj
        └── Program.cs
```

**How to Run:**
1. Restore and build the solution:
   ```
   dotnet restore
   dotnet build
   ```
2. Navigate to the console app directory and run the application:
   ```
   cd LibraryManagement/Presentation/ConsoleApp
   dotnet run
   ```

**Features:**
- Add books to the library
- Iterate over the collection of books

---

### 2. HomeAutomation

**Description:** 
This project demonstrates a home automation system using the Command Pattern with support for undo functionality. It includes commands to turn on/off lights and adjust the thermostat.

**Project Structure:**
```
HomeAutomation
│
├── Core
│   ├── Entities
│   │   ├── Light.cs
│   │   └── Thermostat.cs
│   └── Interfaces
│       └── ICommand.cs
│
├── Application
│   └── Services
│       ├── RemoteControlService.cs
│       └── Commands
│           ├── TurnOnLightCommand.cs
│           ├── TurnOffLightCommand.cs
│           └── AdjustThermostatCommand.cs
│
└── Presentation
    └── ConsoleApp
        ├── HomeAutomation.csproj
        └── Program.cs
```

**How to Run:**
1. Restore and build the solution:
   ```
   dotnet restore
   dotnet build
   ```
2. Navigate to the console app directory and run the application:
   ```
   cd HomeAutomation/Presentation/ConsoleApp
   dotnet run
   ```

**Features:**
- Turn on/off lights
- Adjust thermostat temperature
- Undo last command

---

### 3. CustomerSupport

**Description:** 
This project demonstrates a customer support system using the Chain of Responsibility Pattern. It processes support requests at different levels: Level 1 (basic), Level 2 (intermediate), and Level 3 (advanced).

**Project Structure:**
```
CustomerSupport
│
├── Core
│   ├── Entities
│   │   └── SupportRequest.cs
│   └── Interfaces
│       └── IHandler.cs
│
├── Application
│   └── Handlers
│       ├── Level1Support.cs
│       ├── Level2Support.cs
│       └── Level3Support.cs
│
└── Presentation
    └── ConsoleApp
        ├── CustomerSupport.csproj
        └── Program.cs
```

**How to Run:**
1. Restore and build the solution:
   ```
   dotnet restore
   dotnet build
   ```
2. Navigate to the console app directory and run the application:
   ```
   cd CustomerSupport/Presentation/ConsoleApp
   dotnet run
   ```

**Features:**
- Handle support requests at three levels
- Pass requests to appropriate handler based on level

