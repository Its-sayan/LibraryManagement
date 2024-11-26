CREATE DATABASE LIBRARY;
USE LIBRARY;

CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Author NVARCHAR(255) NOT NULL,
    Category NVARCHAR(100),
    PublishedDate DATE,
    CopiesAvailable INT
);
CREATE TABLE Members (
    MemberId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Phone INT,
    MembershipDate DATE,
    Status NVARCHAR(50)
);
CREATE TABLE Transactions (
    TransactionId INT PRIMARY KEY IDENTITY(1,1),
    BookId INT FOREIGN KEY REFERENCES Books(BookId),
    MemberId INT FOREIGN KEY REFERENCES Members(MemberId),
    IssueDate DATE NOT NULL,
    ReturnDate DATE,
    Fine DECIMAL(10, 2)
);
CREATE TABLE Librarians (
    LibrarianId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Role NVARCHAR(50),
    DateJoined DATE
);