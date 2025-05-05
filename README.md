# Employee Management Application

A full-stack CRUD application built with Angular (Frontend) and .NET Core (Backend) for managing employee records.

![App Screenshot]<!-- Add your screenshot here -->
![Screenshot (224)](https://github.com/user-attachments/assets/f89c72f3-a853-4b0e-bd74-1ae17637151f)
![Screenshot (225)](https://github.com/user-attachments/assets/02c6a7a5-8d50-4eb1-92f2-24a7b0404116)
![Screenshot (226)](https://github.com/user-attachments/assets/4ed0fa9a-186c-4dd9-8e70-ccc812d43c2f)
![Screenshot (227)](https://github.com/user-attachments/assets/6a73e6d0-79bf-4eb6-aac1-5cb6c9d311dd)

## Features

- **Employee CRUD Operations**
  - Create new employees
  - Read employee lists with pagination
  - Update existing employee details
  - Delete employees
- **Advanced Features**
  - Search/filter employees
  - Form validation
  - Responsive UI
  - Pagination (10 items per page)
  - Error handling and notifications

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

## Installation

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/) (v18+)
- [Angular CLI](https://angular.io/cli) (v16+)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (optional)

### Setup

1. Clone the repository:
```bash
git clone https://github.com/IbrahimElarby/IbrahimElarby-EmployeeManagmentAPP.git
cd IbrahimElarby-EmployeeManagmentAPP


cd Backend
dotnet restore
dotnet run


cd Frontend
npm install
ng serve

Running the Application
Start the Backend API:

bash
cd Backend && dotnet run
API will be available at http://localhost:7056

Swagger docs at http://localhost:7056/swagger

Start the Frontend:

bash
cd Frontend && ng serve
Access UI at http://localhost:4200

API Endpoints
Method	Endpoint	Description
GET	/api/employees	Get all employees
GET	/api/employees/{id}	Get single employee
POST	/api/employees	Create new employee
PUT	/api/employees/{id}	Update employee
DELETE	/api/employees/{id}	Delete employee
GET	/api/positions	Get available positions
