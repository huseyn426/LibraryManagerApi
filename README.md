# Library Manager API

Library Manager API is a RESTful Web API built with ASP.NET Core.  
The project allows managing books in a library system and demonstrates basic backend development concepts.

The main goal of this project is to practice backend development using ASP.NET Core, Entity Framework Core, and PostgreSQL.

--------------------------------------------------

TECHNOLOGIES

- C#
- ASP.NET Core Web API
- Entity Framework Core (Code First)
- PostgreSQL
- Dependency Injection (IoC)
- Swagger (API documentation)
- RESTful API

--------------------------------------------------

PROJECT STRUCTURE

LibraryManagerAPI

Controllers
- BooksController.cs

Services
- IBookService.cs
- BookService.cs

Models
- Book.cs

Data
- AppDbContext.cs

Migrations

Program.cs

--------------------------------------------------

FEATURES

The API currently supports the following operations:

- Get all books
- Get book by ID
- Create a new book
- Update a book
- Delete a book

All endpoints follow RESTful API principles.

--------------------------------------------------

DATABASE

The project uses Entity Framework Core with the Code First approach.

Example Book model:

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
}

--------------------------------------------------

SETUP

1. Clone the repository

git clone https://github.com/yourusername/library-manager-api.git

2. Configure the database connection

Open the appsettings.json file and update the connection string:

"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=5432;Database=librarydb;Username=postgres;Password=yourpassword"
}

3. Create the database using migrations

Open Package Manager Console and run:

Add-Migration InitialCreate

Update-Database

Entity Framework Core will automatically create the database tables.

4. Run the project

dotnet run

or run the project from Visual Studio.

Swagger will be available at:

https://localhost:{port}/swagger

--------------------------------------------------

API ENDPOINTS

GET /api/books

GET /api/books/{id}

POST /api/books

PUT /api/books/{id}

DELETE /api/books/{id}

--------------------------------------------------

PROJECT PURPOSE

This project was created to practice:

- ASP.NET Core Web API development
- Entity Framework Core
- Dependency Injection
- RESTful API design
- Working with PostgreSQL
