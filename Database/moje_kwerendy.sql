DELETE FROM albums WHERE id='1';
DELETE FROM albums WHERE id='2';
DELETE FROM albums WHERE author='taco';
UPDATE albums SET title = 'sprzedaz' WHERE ID = 5;

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;

INSERT INTO Customers (CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES ('Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

INSERT INTO albums (id, date, author, title, description) VALUES ('60','2099-12-18 00:20:11','Paul Vojcicki', 'Titanic', 'MEGA FILM!');

DROP TABLE albums;
DROP DATABASE pawelwojcikDB.sqlite;

CREATE TABLE 'albums'('id' INTEGER PRIMARY KEY AUTOINCREMENT, 'date' TEXT, 'author' TEXT, 'title' TEXT, 'description' TEXT);