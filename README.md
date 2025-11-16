# ELDNET Enrollment System

A comprehensive web-based enrollment system built with ASP.NET Core, designed to manage student enrollments and academic transactions.

## Overview

The ELDNET Enrollment System is a full-stack web application that provides a centralized platform for managing student enrollment processes, including enrollment tracking, master file management, and transactional operations.

## Technologies Used

- **Backend**: ASP.NET Core (C#)
- **Frontend**: HTML, CSS, JavaScript
- **Database**: SQL Server
- **Architecture**: MVC (Model-View-Controller) Pattern
- **Language Distribution**:
  - CSS: 66.8%
  - HTML: 17.6%
  - C#: 15.5%
  - JavaScript: 0.1%

## Project Structure

The project follows a standard ASP.NET Core MVC structure:

```
EnrollmentSystem/
├── Controllers/              # HTTP request handlers
│   ├── HomeController.cs
│   ├── MasterFilesController.cs
│   └── TransactionalController.cs
├── Models/                   # Data models and entities
│   ├── Dto/                  # Data Transfer Objects
│   ├── Entities/             # Database entity models
│   └── ErrorViewModel.cs
├── Views/                    # UI templates (Razor)
│   ├── Home/
│   ├── MasterFiles/
│   ├── Shared/
│   ├── Transactional/
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── Data/                     # Database context and repositories
├── Migrations/               # Entity Framework migrations
├── Properties/               # Project properties and configurations
├── wwwroot/                  # Static files (CSS, JavaScript, images)
├── Program.cs                # Application entry point and configuration
├── EnrollmentSystem.csproj   # Project file
├── appsettings.json          # Configuration settings
└── appsettings.Development.json
```

## Key Components

### Controllers
- **HomeController**: Handles home page and general navigation
- **MasterFilesController**: Manages master data (students, courses, etc.)
- **TransactionalController**: Handles enrollment transactions and operations

### Models
- **DTOs**: Data Transfer Objects for API communication
- **Entities**: Database models representing core business entities
- **Migrations**: Database schema evolution tracking

### Views
- **Home**: Landing page and dashboard
- **MasterFiles**: CRUD operations for master data
- **Transactional**: Enrollment process and transaction management
- **Shared**: Common layout and partial views

## Configuration

The application uses `appsettings.json` for configuration:

```json
{
  "ConnectionStrings": {
    "ApplicationDbContext": "your_connection_string_here"
  },
  // Additional configuration settings
}
```

## Features

- Student enrollment management
- Master file maintenance
- Transaction processing
- Database persistence with Entity Framework Core
- Session management with customizable timeout
- Authentication and authorization
- Error handling and exception middleware

## Getting Started

### Prerequisites

- .NET Core SDK (version as specified in the project)
- SQL Server (local or remote)
- Visual Studio or Visual Studio Code

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/duriandurino/ELDNET-EnrollmentSystem.git
   cd ELDNET-EnrollmentSystem/EnrollmentSystem
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

3. Update database connection string in `appsettings.json`

4. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

6. Open your browser and navigate to `https://localhost:5001` (or the configured port)

## Database Migrations

The project includes Entity Framework Core migrations to manage database schema changes. Apply migrations using:

```bash
dotnet ef database update
```

## Development

The project is currently in a development phase with recent structural reorganization. Key services are configured in `Program.cs`:

- Controllers with Views
- HTTP context accessor
- Session management
- Database context
- Exception handling middleware

## Project Status

This project is actively maintained. The latest commit message indicates a major overhaul of the system architecture.

## License

This project is maintained by [duriandurino](https://github.com/duriandurino).

## Support

For issues, questions, or contributions, please refer to the repository's issues section.
