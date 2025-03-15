# User Management API

## Overview
This project is a minimal API for managing users, providing CRUD (Create, Read, Update, Delete) functionality along with input validations and middleware for logging and authentication.

## Project Structure
```
UserManagement
├── Controllers
│   └── UserController.cs
├── Middleware
│   ├── AuthenticationMiddleware.cs
│   └── LoggingMiddleware.cs
├── Models
│   └── User.cs
├── Services
│   └── UserService.cs
├── Program.cs
├── appsettings.json
└── README.md
```

## Features
- **User Management**: Create, retrieve, update, and delete user records.
- **Input Validation**: Ensures that user data meets specified criteria before processing.
- **Authentication Middleware**: Secures endpoints by verifying user credentials.
- **Logging Middleware**: Logs request and response details for monitoring and debugging.

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd UserManagement
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```
4. Run the application:
   ```
   dotnet run
   ```

## API Endpoints
- **GET /users**: Retrieve a list of all users.
- **GET /users/{id}**: Retrieve a specific user by ID.
- **POST /users**: Create a new user.
- **PUT /users/{id}**: Update an existing user.
- **DELETE /users/{id}**: Delete a user by ID.

## Usage
After starting the application, you can interact with the API using tools like Postman or curl. Ensure to include authentication tokens where required.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.