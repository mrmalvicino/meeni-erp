/*CREATE DATABASE meeni_erp_db
GO*/

USE meeni_erp_db
GO

/*CREATE TABLE customers(
RegStatus bit,
Id int primary key identity,
RegName varchar(50),
RegDescription varchar(50),
LegalId varchar(50),
Phone int,
Email varchar(50),
Country varchar(50),
Province varchar(50),
City varchar(50),
Street varchar(50),
StreetNumber int,
Flat varchar(50),
ZipCode varchar(50),
PaymentMethod varchar(50),
InvoiceCategory char,
SalesAmount int
)

INSERT INTO customers
(RegStatus, RegName, RegDescription, LegalId, Phone, Email, Country, Province, City, Street, StreetNumber, Flat, ZipCode, PaymentMethod, InvoiceCategory, SalesAmount) VALUES
('True', 'Johnson Construction', 'Residential Contractor', '20374567769', '1157863846', 'info@johnsonconstruction.com', 'Argentina', 'Buenos Aires', 'CABA', '9 de Julio', '1290', 'NULL', 'C1000', 'Crédito', 'A', '15'),
('True', 'Smith Commercial', 'Comercial Developer', '20203788463', '1157873654', 'contact@smithcommercial.com', 'Argentina', 'Buenos Aires', 'CABA', 'Córdoba', '2345', '9B', 'C1000', 'Débito', 'B', '5'),
('True', 'Greenfield Builders', 'Eco Friendly Construction', '30347684959', '1158994786', 'info@greenfield.com', 'Argentina', 'Buenos Aires', 'San Fernando', 'Perón', '345', 'NULL', 'B1646', 'Efectivo', 'C', '26'),
('True', 'Urban Renovations', 'Urban Renewal Experts', '23293348579', '1158897263', 'info@urbanrenovations.com', 'Argentina', 'Buenos Aires', 'Tigre', 'Cazón', '768', 'NULL', 'B1648', 'Cheque', 'A', '2');*/

SELECT * FROM customers

--SELECT Id, RegName FROM customers