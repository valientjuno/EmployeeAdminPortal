# Employee Admin Portal API

## Project Description

The Employee Admin Portal API is a RESTful web service built using **ASP.NET Core** and **Entity Framework Core**. The purpose of this application is to provide a simple and efficient way to manage employee data, including creating, viewing, updating, and deleting employee records.

This project demonstrates how to build a backend API that connects to a database using EF Core, allowing developers to perform data operations without writing raw SQL. It follows standard REST principles and is designed to be scalable, maintainable, and easy to extend.

---

## How to Use the Application

This API is designed to be tested using tools like **Postman** or **Swagger UI**. It allows you to interact with employee data through HTTP requests.

### Step 1: Start the API

Run the application:

```
dotnet run
```

Once running, the API will be available at:

```
https://localhost:xxxx/api/employees
```

---

### Step 2: Use an API Testing Tool

Use one of the following:

* Postman
* Swagger UI (if enabled)
* Browser (GET requests only)

---

### Step 3: Perform CRUD Operations

#### 1. Get All Employees

Retrieve all employee records:

```
GET /api/employees
```

---

#### 2. Get Employee by ID

Retrieve a single employee using their unique ID:

```
GET /api/employees/{id}
```

---

#### 3. Add a New Employee

Create a new employee record:

```
POST /api/employees
```

Example request body:

```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "phone": "1234567890",
  "salary": 50000
}
```

---

#### 4. Update an Employee

Update an existing employee record:

```
PUT /api/employees?id={id}
```

Provide updated values in the request body.

---

#### 5. Delete an Employee

Remove an employee from the database:

```
DELETE /api/employees/{id}
```

---

## Technologies Used

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server (LocalDB)
* LINQ

---

## Features

* [x] CRUD Operations (Create, Read, Update, Delete)
* [x] Entity Framework Core Integration
* [x] Database Migrations
* [x] DTO Usage for Data Transfer
* [x] LINQ Queries
* [x] Basic Error Handling


---

## Project Structure

```
EmployeeAdminPortal/
├── Controllers/
│   └── EmployeesController.cs
├── Models/
│   ├── Entities/
│   │   └── Employee.cs
│   └── DTOs/
│       ├── AddEmployeeDto.cs
│       └── UpdateEmployeeDto.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Migrations/
├── Program.cs
├── appsettings.json
└── README.md
```

---

## Setup Instructions

### 1. Clone the Repository

```
git clone <your-repository-url>
cd EmployeeAdminPortal
```

### 2. Install Dependencies

```
dotnet restore
```

### 3. Configure Database

Update the connection string in `appsettings.json`:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDb;Trusted_Connection=True;"
}
```

---

## Apply Migrations

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## Challenges / Future Improvements

* Add authentication and authorization
* Improve validation and error handling
* Implement async/await for better performance
* Add pagination for large datasets
* Use repository pattern

---

## Notes

* Ensure SQL Server LocalDB is installed
* Run migrations before starting the API
* Use Postman or Swagger to test endpoints

---

## Author
Jesse Doake
Developed as part of a C# API and Entity Framework Core learning project.
