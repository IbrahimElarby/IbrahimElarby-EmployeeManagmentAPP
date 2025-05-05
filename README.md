# Employee Management Application

A full-stack CRUD application built with Angular (Frontend) and .NET Core (Backend) for managing employee records.

![App Screenshot]<!-- Add your screenshot here -->
![Screenshot (224)](https://github.com/user-attachments/assets/f89c72f3-a853-4b0e-bd74-1ae17637151f)
![Screenshot (225)](https://github.com/user-attachments/assets/02c6a7a5-8d50-4eb1-92f2-24a7b0404116)
![Screenshot (226)](https://github.com/user-attachments/assets/4ed0fa9a-186c-4dd9-8e70-ccc812d43c2f)
![Screenshot (227)](https://github.com/user-attachments/assets/6a73e6d0-79bf-4eb6-aac1-5cb6c9d311dd)


# Employee Management Application

A full-stack CRUD application built with Angular (Frontend) and .NET Core (Backend) for managing employee records.


## Features

- **Employee CRUD Operations**: Create, Read, Update, and Delete employee records.
- **Advanced Features**:
  - Search and filter employees.
  - Form validation.
  - Responsive UI.
  - Pagination (10 items per page).
  - Error handling and notifications.

## Technologies Used

### Frontend

- Angular 16+
- Angular Material UI
- RxJS
- TypeScript
- HTML5/CSS3

### Backend

- .NET Core 7+
- Entity Framework Core
- SQL Server Express
- Swagger/OpenAPI
- C#

## Prerequisites

Ensure the following are installed on your system:

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Node.js (LTS version)](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/IbrahimElarby/IbrahimElarby-EmployeeManagmentAPP.git
cd IbrahimElarby-EmployeeManagmentAPP
```

### 2. Configure the Connection String

Update the `appsettings.json` file located in the `Backend` project directory to match your SQL Server configuration.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

**Note**: Replace `YOUR_SERVER_NAME` with your actual SQL Server instance name. If you're using SQL Server Authentication, use:

```json
"DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;MultipleActiveResultSets=true"
```

### 3. Apply Migrations and Update the Database

Navigate to the `Backend` project directory and run:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Backend Server

```bash
dotnet run
```

API available at: `https://localhost:7056` 

### 5. Run the Frontend Application

```bash
cd ../Frontend
npm install
ng serve
```

Angular app will run at: `http://localhost:4200`

## API Documentation

Visit Swagger UI:

```
https://localhost:7056/swagger
```

## Contributing

Contributions welcome! Fork the repo and submit a pull request.

## License

MIT License



