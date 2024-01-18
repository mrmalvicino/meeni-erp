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
ImageUrl varchar(255),
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
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, LegalId, PhoneCountry, PhoneArea, PhoneNumber, Email, ImageUrl, Country, Province, City, ZipCode, Street, StreetNumber, Flat, PaymentMethod, InvoiceCategory, SalesAmount) VALUES
('True', 'False', '', '', 'Johnson Construction', 'Residential Contractor', '20374567769', '54', '911', '1527863846', 'info@johnsonconstruction.com', 'https://img.freepik.com/vector-gratis/logotipo-empresa-construccion-diseno-plano_23-2150051909.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', '9 de Julio', '1290', '', 'Crédito', 'A', '5'),
('False', 'False', '', '', 'Smith Commercial', 'Comercial Developer', '20203788463', '54', '911', '1547873654', 'contact@smithcommercial.com', 'https://img.freepik.com/vector-gratis/logotipo-excavadora-construccion-edificios_23-2148657768.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', 'Córdoba', '2345', '9B', 'Débito', 'B', '5'),
('False', 'False', '', '', 'Greenfield Builders', 'Eco Friendly Construction', '30347684959', '54', '911', '1568994786', 'info@greenfield.com', 'https://img.freepik.com/vector-premium/logotipo-enlucido-construccion-diseno-ladrillo-paleta_501861-302.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'Argentina', 'Buenos Aires', 'San Fernando', 'B1646', 'Perón', '345', '', 'Efectivo', 'C', '6'),
('True', 'False', '', '', 'Urban Renovations', 'Urban Renewal Experts', '23293348579', '54', '911', '1558897263', 'info@urbanrenovations.com', '', 'Argentina', 'Buenos Aires', 'Tigre', 'B1648', 'Cazón', '768', '', 'Cheque', 'A', '2'),
('True', 'True', 'Carlos', 'Berlinguieri', '', '', '38274478', '54', '911', '1557736789', 'berlinguieric@gmail.com', '', 'Argentina', 'Buenos Aires', 'Pacheco', 'B1617', 'Santa Fé', '1290', '', 'Efectivo', 'C', '1');

SELECT * FROM customers