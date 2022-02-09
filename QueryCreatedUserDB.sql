CREATE DATABASE UsuarioDB;
CREATE TABLE Usuario (
    Id Int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(100) NOT NULL,
    Birthday datetime NOT NULL,
    Email varchar(100) NOT NULL,
	Telephone int NOT NULL,
    Active bit NOT NULL
);