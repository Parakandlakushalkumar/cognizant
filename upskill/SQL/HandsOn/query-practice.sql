SELECT Title, PublishedYear
FROM Books;

SELECT Title, AvailableCopies
FROM Books
WHERE AvailableCopies > 2;

SELECT Title, PublishedYear
FROM Books
ORDER BY PublishedYear DESC;

SELECT
    AuthorId,
    COUNT(*) AS TotalBooks
FROM Books
GROUP BY AuthorId;

SELECT
    a.AuthorName,
    b.Title,
    b.AvailableCopies
FROM Authors a
INNER JOIN Books b ON a.AuthorId = b.AuthorId;

UPDATE Books
SET AvailableCopies = AvailableCopies + 1
WHERE Title = 'Clean Code';

BEGIN TRANSACTION;

UPDATE Books
SET AvailableCopies = AvailableCopies - 1
WHERE BookId = 1 AND AvailableCopies > 0;

COMMIT TRANSACTION;
