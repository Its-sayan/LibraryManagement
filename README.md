# Library Management System

A Library Management System (LMS) built using ASP.NET Core MVC and SQL Server. This project includes functionalities for managing books, members, transactions, and librarians, along with a custom login and registration system.

## Table of Contents
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [Database Design](#database-design)
- [CI/CD Pipeline](#cicd-pipeline)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Features
- User Management: Register, Login, Logout, Role-based access control.
- Book Management: CRUD operations for books, tracking availability and location.
- Member Management: Manage member details, track active and inactive memberships.
- Book Issue/Return: Issue books to members, track return dates, calculate fines.
- Fine Calculation: Automatic fine calculation based on return date.
- Search and Reports: Search features for books, members, transactions, and various reports.

## Technologies
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Azure DevOps
- Bootstrap (for styling)

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/LibraryManagementSystem.git
   cd LibraryManagementSystem
