CREATE TABLE "Book"(
    "Id" INT NOT NULL IDENTITY(1, 1),
    "Isbn" NVARCHAR(255) NOT NULL,
    "Title" NVARCHAR(255) NOT NULL,
    "ReleaseDate" DATE NOT NULL,
    "EditionDate" DATE NULL,
    "Page" INT NOT NULL,
    "Quantity" INT NOT NULL,
    "AuthorID" INT NOT NULL,
    "PublisherID" INT NOT NULL
);
ALTER TABLE
    "Book" ADD CONSTRAINT "book_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Publischer"(
    "Id" INT NOT NULL IDENTITY(1, 1),
    "Name" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Publischer" ADD CONSTRAINT "publischer_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Author"(
    "Id" INT NOT NULL IDENTITY(1, 1),
    "Name" NVARCHAR(255) NOT NULL,
    "LastName" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "Author" ADD CONSTRAINT "author_id_primary" PRIMARY KEY("Id");
CREATE TABLE "User"(
    "Id" INT NOT NULL IDENTITY(1, 1),
    "Name" NVARCHAR(255) NOT NULL,
    "LastName" NVARCHAR(255) NOT NULL,
    "Email" NVARCHAR(255) NOT NULL,
    "Password" NVARCHAR(255) NOT NULL,
    "PhoneNumber" NVARCHAR(255) NOT NULL
);
ALTER TABLE
    "User" ADD CONSTRAINT "user_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Book_User"(
    "BookId" INT NOT NULL,
    "UserId" INT NOT NULL,
    "DateBorrowStart" DATE NOT NULL,
    "DateBorrowEnd" DATE NOT NULL
);
CREATE TABLE "Author_Book"(
    "AuthorID" INT NOT NULL,
    "BookID" INT NOT NULL
);
CREATE TABLE "Dvd"(
    "Id" INT NOT NULL IDENTITY(1, 1),
    "Code" NVARCHAR(255) NOT NULL,
    "Title" NVARCHAR(255) NOT NULL,
    "ReleaseDate" DATE NOT NULL,
    "EditionDate" DATE NULL,
    "Duration" INT NOT NULL,
    "Quantity" INT NOT NULL,
    "AuthorID" INT NOT NULL,
    "PublisherID" INT NOT NULL
);
ALTER TABLE
    "Dvd" ADD CONSTRAINT "dvd_id_primary" PRIMARY KEY("Id");
CREATE TABLE "Author_Dvd"(
    "AuthorId" INT NOT NULL,
    "DvdId" INT NOT NULL
);
CREATE TABLE "Dvd_User"(
    "DvdId" INT NOT NULL,
    "UserId" INT NOT NULL,
    "DateBorrowStart" DATE NOT NULL,
    "DateBorrowEnd" DATE NOT NULL
);
ALTER TABLE
    "Author_Book" ADD CONSTRAINT "author_book_bookid_foreign" FOREIGN KEY("BookID") REFERENCES "Book"("Id");
ALTER TABLE
    "Book" ADD CONSTRAINT "book_publisherid_foreign" FOREIGN KEY("PublisherID") REFERENCES "Publischer"("Id");
ALTER TABLE
    "Author_Book" ADD CONSTRAINT "author_book_authorid_foreign" FOREIGN KEY("AuthorID") REFERENCES "Author"("Id");
ALTER TABLE
    "Author_Dvd" ADD CONSTRAINT "author_dvd_authorid_foreign" FOREIGN KEY("AuthorId") REFERENCES "Author"("Id");
ALTER TABLE
    "Dvd_User" ADD CONSTRAINT "dvd_user_dvdid_foreign" FOREIGN KEY("DvdId") REFERENCES "Dvd"("Id");
ALTER TABLE
    "Dvd_User" ADD CONSTRAINT "dvd_user_userid_foreign" FOREIGN KEY("UserId") REFERENCES "Book"("Id");
ALTER TABLE
    "Author_Dvd" ADD CONSTRAINT "author_dvd_dvdid_foreign" FOREIGN KEY("DvdId") REFERENCES "Dvd"("Id");
ALTER TABLE
    "Dvd" ADD CONSTRAINT "dvd_publisherid_foreign" FOREIGN KEY("PublisherID") REFERENCES "Publischer"("Id");
ALTER TABLE
    "Book_User" ADD CONSTRAINT "book_user_userid_foreign" FOREIGN KEY("UserId") REFERENCES "User"("Id");
ALTER TABLE
    "Book_User" ADD CONSTRAINT "book_user_bookid_foreign" FOREIGN KEY("BookId") REFERENCES "Book"("Id");