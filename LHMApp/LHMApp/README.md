# LHM Hospital Appointment MVC Application

A complete ASP.NET Core MVC + Entity Framework Core + SQL Server implementation of the Case Study 2 requirements.

## Requirements
- .NET 8 SDK
- SQL Server LocalDB (or SQL Server)
- Visual Studio 2022 / VS Code

## Login
- Username: `admin`
- Password: `admin123`

Successful login redirects to `Appointment/Index`. Patient and Appointment controllers require authentication.

## Database
The default connection string uses:
`(localdb)\\MSSQLLocalDB` and database `LHM`.

If you use another SQL Server instance, edit `appsettings.json`.

### Package Manager Console
```powershell
Update-Database
```

The initial migration is already included. If you change the models, use:
```powershell
Add-Migration YourMigrationName
Update-Database
```

### CLI
```bash
dotnet restore
dotnet ef database update
dotnet run
```

If `dotnet ef` is not installed:
```bash
dotnet tool install --global dotnet-ef --version 8.0.11
```

## Implemented requirements
- Patient and Appointment EF Core entities
- Identity(1,1) integer primary keys
- Required fields and validation data annotations
- Patient name length 4-35
- Contact number format validation
- Patient/Appointment relationship and navigation properties
- `LHMDbContext` with SQL Server configuration
- `ILHMRepo` and `LHMRepo`
- Service layer
- Login/logout using cookie authentication
- Unauthorized access redirected to Login
- Patient Create, Index and Details
- Dynamic age calculation from DateOfBirth
- Appointment Create and Index
- Structured try/catch error handling
- Login is the startup page
