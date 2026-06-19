CREATE DATABASE UpskillingLibrary;
GO

USE UpskillingLibrary;
GO

CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY IDENTITY(1,1),
    AuthorName VARCHAR(100) NOT NULL,
    Country VARCHAR(50)
);

CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title VARCHAR(150) NOT NULL,
    AuthorId INT NOT NULL,
    PublishedYear INT CHECK (PublishedYear >= 1900),
    AvailableCopies INT DEFAULT 1,
    CONSTRAINT FK_Books_Authors FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
);

INSERT INTO Authors (AuthorName, Country)
VALUES
    ('Robert Martin', 'USA'),
    ('Kathy Sierra', 'USA'),
    ('Andrew Hunt', 'USA');

INSERT INTO Books (Title, AuthorId, PublishedYear, AvailableCopies)
VALUES
    ('Clean Code', 1, 2008, 3),
    ('Head First Java', 2, 2005, 2),
    ('The Pragmatic Programmer', 3, 1999, 4);

SELECT
    b.Title,
    a.AuthorName,
    b.PublishedYear,
    b.AvailableCopies
FROM Books b
INNER JOIN Authors a ON b.AuthorId = a.AuthorId;
