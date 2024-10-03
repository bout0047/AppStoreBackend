
# AppStoreBackend

## Overview
**AppStoreBackend** is a RESTful API developed with **ASP.NET Core** to manage and serve applications in an app store setting. It relies on **SQL Server** for data storage and provides features for CRUD operations, authentication, and cross-origin resource sharing (CORS) configuration, making it ideal for integration with external clients, such as a Flutter frontend.

## Features
- **CRUD Operations**: Enables Create, Read, Update, and Delete operations for managing apps.
- **JWT Authentication**: Ensures secure access to protected endpoints.
- **Swagger Documentation**: Provides easy access to API documentation for exploring and testing endpoints.
- **CORS Support**: Configured to handle cross-origin requests, allowing safe interaction with external domains.
- **SQL Server Integration**: Uses SQL Server for reliable data persistence.

## Getting Started

### Prerequisites
Make sure you have the following requirements in place before proceeding:
- **.NET 6.0 SDK**: Required to build and run the application.
- **SQL Server**: The backend relies on SQL Server for data storage.
- **Visual Studio** or **Visual Studio Code**: Recommended for development and debugging purposes.

### Installation

1. **Clone the Repository**:
   To get a local copy of the project, run:
   ```sh
   git clone https://github.com/bout0047/AppStoreBackend.git
   ```

2. **Navigate to the Project Directory**:
   Move into the cloned directory:
   ```sh
   cd AppStoreBackend
   ```

3. **Set Up the Database**:
   Ensure your SQL Server instance is up and running. Update the connection string in the `appsettings.json` file to match your SQL Server configuration.

4. **Run the Application**:
   Use the following command to run the application:
   ```sh
   dotnet run
   ```

5. **Access the API Documentation**:
   Once the application is running, navigate to `http://localhost:<port>/swagger` in your browser to view and interact with the API documentation via Swagger.

## Usage
### API Endpoints
The **AppStoreBackend** provides several endpoints for managing the app store:
- **GET /api/apps**: Retrieves a list of available apps.
- **POST /api/apps**: Adds a new app to the store (requires authentication).
- **PUT /api/apps/{id}**: Updates an existing app (requires authentication).
- **DELETE /api/apps/{id}**: Deletes an app (requires authentication).

Make sure to provide a valid JWT token for endpoints that require authentication.

### Authentication
To access protected endpoints, you will need to authenticate and receive a JWT token. You can then use this token in your API requests by including it in the `Authorization` header, as shown below:
```
Authorization: Bearer <your_jwt_token>
```

## Development
### Running Locally
You can use **Visual Studio** or **Visual Studio Code** for development. Set up your environment using the built-in configuration, and run the backend for testing and development.

### Configuring CORS
CORS is configured to allow requests from authorized domains. You can update the CORS settings in the `Startup.cs` file to modify which domains are allowed to interact with the API.
