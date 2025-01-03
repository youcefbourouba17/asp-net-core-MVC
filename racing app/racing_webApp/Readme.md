

# Project Name

## Overview

![1](https://github.com/user-attachments/assets/cc3f3b4c-2b90-4520-ac2e-b20e5a82bbbe)
![2](https://github.com/user-attachments/assets/b1da86ed-0712-456e-bfea-32ba76bbb077)
![3](https://github.com/user-attachments/assets/dac832a7-ef3c-430b-803d-81dda6315b51)
![4](https://github.com/user-attachments/assets/ffdac3f1-3d86-4840-971b-8b2c0b0e1f6d)


This project is a web application built using ASP.NET Core with Razor Pages and Blazor Pages, and SQL Server. The backend is developed with the latest version of ASP.NET Core, utilizing Razor Pages for server-side rendering and Blazor Pages for interactive web components. Entity Framework Core is used for database interactions and authentication. Additionally, Cloudinary is used for media management and storage.

## Features

- **Frontend:** Blazor Pages
- **Backend:** ASP.NET Core (latest version) with Razor Pages
- **Database:** SQL Server with Entity Framework Core
- **Authentication:** Entity Framework Core for user management and authentication
- **Media Management:** Cloudinary for storing and managing media assets
- **Node.js:** Version 20 (if needed for any other tools)

## Prerequisites

Ensure you have the following installed on your development machine:

- [.NET SDK](https://dotnet.microsoft.com/download) (latest version)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)

## Getting Started

### Backend

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository-name.git
   cd your-repository-name
   ```

2. **Set up `app.config`, `appsettings.json`, and Cloudinary:**

   Ensure you have configured the `app.config` and `appsettings.json` files with the necessary settings, including your SQL Server connection string, Cloudinary credentials, authentication settings, and any other environment-specific configurations.

   Example Cloudinary configuration in `appsettings.json`:
   ```json
   "Cloudinary": {
     "CloudName": "your_cloud_name",
     "ApiKey": "your_api_key",
     "ApiSecret": "your_api_secret"
   }
   ```

3. Restore .NET dependencies:
   ```bash
   dotnet restore
   ```

4. Update the database:
   ```bash
   dotnet ef database update
   ```

5. Run the backend:
   ```bash
   dotnet run
   ```

### Frontend

1. Run the Blazor application:

   The Blazor Pages are part of the ASP.NET Core application and will be served directly from the backend. Once the backend is running, you can interact with the Blazor components.

2. Open your browser and navigate to `http://localhost:5000` (or the port specified in your project settings).

## Database Setup

This project uses SQL Server. Ensure your connection string is properly configured in the `appsettings.json` file in the root of the project:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_username;Password=your_password;"
}
```

## Entity Framework Migrations

To add a new migration:

```bash
dotnet ef migrations add MigrationName
```

To update the database with the latest migration:

```bash
dotnet ef database update
```

## Authentication

This project uses Entity Framework Core for authentication. Ensure that your authentication settings are correctly configured in your `Startup.cs` or `Program.cs` file (depending on your .NET version). You will need to set up your identity models and configure the authentication services.

## Razor Pages and Blazor Pages

- **Razor Pages:** Used for server-side rendering. Ensure that your Razor Pages are correctly set up and that routes are configured as needed in the `Startup.cs` file.
  
- **Blazor Pages:** Used for interactive web components. Make sure that your Blazor components are properly integrated into your project.

## Cloudinary Integration

This project uses Cloudinary for media management and storage. Ensure that your Cloudinary settings are properly configured in the `appsettings.json` file, and integrate Cloudinary SDKs into your project as needed for uploading and managing media.

## Contributing

Contributions are welcome! Please submit a pull request for any changes you would like to see.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
