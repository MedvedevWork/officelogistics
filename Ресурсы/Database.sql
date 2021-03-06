CREATE DATABASE officelogistics

USE officelogistics
GO

CREATE TABLE Users(ID INT NOT NULL, Login VARCHAR(50) NOT NULL, Password VARCHAR(50) NOT NULL, Role INT NOT NULL) 
ALTER TABLE Users
ADD CONSTRAINT UserID_pk PRIMARY KEY (ID)

CREATE TABLE Roles (ID INT NOT NULL, Title VARCHAR(30))
ALTER TABLE Roles 
ADD CONSTRAINT roleID_pk PRIMARY KEY (ID)

-- Users fk

ALTER TABLE Users
ADD CONSTRAINT RoleID_fk FOREIGN KEY (Role)
REFERENCES Roles (ID)

-- New tables


CREATE TABLE Buyers (ID INT NOT NULL, Name VARCHAR(30))
ALTER TABLE Buyers
ADD CONSTRAINT buyerID_pk PRIMARY KEY (ID)

CREATE TABLE Suppliers (ID INT NOT NULL, Name VARCHAR(50))
ALTER TABLE Suppliers 
ADD CONSTRAINT supplierID_pk PRIMARY KEY (ID)

CREATE TABLE Items (ID INT NOT NULL, Shelf INT NOT NULL, Name VARCHAR(1000) NOT NULL, Count INT NOT NULL, fCost INT NOT NULL, sCost INT NOT NULL)
ALTER TABLE Items 
ADD CONSTRAINT itemID_pk PRIMARY KEY (ID)




