# README.md — AuctionHouseNetCoreMvc

# AuctionHouse

Personal ASP.NET Core MVC project created to practice building a web application around an auction-house concept.

The project combines MVC, database access, authentication, external service integration, and email functionality.

## Technologies

* C#
* ASP.NET Core MVC
* ASP.NET Core 3.1
* Entity Framework Core
* SQL Server
* ASP.NET Core Identity
* Stripe
* SendGrid
* Razor Pages / Razor Views

## Main technical areas

### Database

Entity Framework Core is used together with SQL Server for application data access.

### Authentication

ASP.NET Core Identity is used for user authentication and authorization.

### Payments

The application contains a **Stripe integration using a test/demo setup**.

The integration was created for development and learning purposes and is not intended to represent a production payment system.

### Email

SendGrid is used as an external email service.

### Pagination

The project uses `ReflectionIT.Mvc.Paging` to support paginated data presentation.

## Project structure

```text
AuctionHouseNetCoreMvc
└── AuctionHouseApp
    ├── Controllers
    ├── Data
    ├── Models
    ├── Services
    ├── Views
    └── Areas
```

## Purpose of the project

The main purpose of this project was to gain practical experience with:

* ASP.NET Core MVC
* Entity Framework Core
* authentication and authorization
* dependency injection
* external service integration
* database-backed web applications
* structuring an MVC application

## Project status

This is a personal learning project created with an older ASP.NET Core version.
