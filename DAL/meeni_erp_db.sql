CREATE DATABASE meeni_erp_db
GO

USE meeni_erp_db
GO

CREATE TABLE customers(
Id int primary key identity,
ActiveStatus bit,
IsPerson bit,
FirstName varchar(50),
LastName varchar(50),
BusinessName varchar(50),
BusinessDescription varchar(50),
LegalId bigint,
PhoneCountry int,
PhoneArea int,
PhoneNumber int,
Email varchar(50),
Country varchar(50),
Province varchar(50),
City varchar(50),
ZipCode varchar(10),
Street varchar(50),
StreetNumber int,
Flat varchar(50),
PaymentMethod varchar(50),
InvoiceCategory char,
SalesAmount int
)

INSERT INTO customers
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, LegalId, PhoneCountry, PhoneArea, PhoneNumber, Email, Country, Province, City, ZipCode, Street, StreetNumber, Flat, PaymentMethod, InvoiceCategory, SalesAmount) VALUES
('True', 'False', NULL, NULL, 'Johnson Construction', 'Residential Contractor', '20374567769', '54', '911', '1527863846', 'info@johnsonconstruction.com', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', '9 de Julio', '1290', NULL, 'Cr�dito', 'A', '5'),
('False', 'False', NULL, NULL, 'Smith Commercial', 'Comercial Developer', '20203788463', '54', '911', '1547873654', 'contact@smithcommercial.com', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', 'C�rdoba', '2345', '9B', 'D�bito', 'B', '5'),
('False', 'False', NULL, NULL, 'Greenfield Builders', 'Eco Friendly Construction', '30347684959', '54', '911', '1568994786', 'info@greenfield.com', 'Argentina', 'Buenos Aires', 'San Fernando', 'B1646', 'Per�n', '345', NULL, 'Efectivo', 'C', '6'),
('True', 'False', NULL, NULL, 'Urban Renovations', 'Urban Renewal Experts', '23293348579', '54', '911', '1558897263', 'info@urbanrenovations.com', 'Argentina', 'Buenos Aires', 'Tigre', 'B1648', 'Caz�n', '768', NULL, 'Cheque', 'A', '2'),
('True', 'True', 'Carlos', 'Berlinguieri', NULL, NULL, '38274478', '54', '911', '1557736789', 'berlinguieric@gmail.com', 'Argentina', 'Buenos Aires', 'Pacheco', 'B1617', 'Santa F�', '1290', NULL, 'Efectivo', 'C', '1');

SELECT * FROM customers