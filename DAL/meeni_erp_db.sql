-- DATABASE

CREATE DATABASE meeni_erp_db
GO

USE meeni_erp_db
GO

-- CUSTOMERS

CREATE TABLE customers(
Id int primary key identity,
ActiveStatus bit,
IsPerson bit,
FirstName varchar(30),
LastName varchar(30),
BusinessName varchar(30),
BusinessDescription varchar(30),
ImageUrl varchar(300),
Email varchar(30),
PhoneCountry int,
PhoneArea int,
PhoneNumber int,
AdressCountry varchar(30),
AdressProvince varchar(30),
AdressCity varchar(30),
AdressZipCode varchar(30),
AdressStreet varchar(30),
AdressStreetNumber int,
AdressFlat varchar(30),
LegalIdXX varchar(30),
LegalIdDNI int,
LegalIdY varchar(30),
PaymentMethod varchar(30),
InvoiceCategory varchar(30),
SalesAmount int
)

INSERT INTO customers
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, SalesAmount) VALUES
('True', 'False', '', '', 'Johnson Construction', 'Residential Contractor', 'https://img.freepik.com/vector-gratis/logotipo-empresa-construccion-diseno-plano_23-2150051909.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'info@johnsonconstruction.com', '54', '911', '1527863846', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', '9 de Julio', '1290', '', '20', '37456776', '9', 'Crédito', 'A', '5'),
('False', 'False', '', '', 'Smith Commercial', 'Comercial Developer', 'https://img.freepik.com/vector-gratis/logotipo-excavadora-construccion-edificios_23-2148657768.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'contact@smithcommercial.com', '54', '911', '1547873654', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', 'Córdoba', '2345', '9B', '20', '20378846', '3', 'Débito', 'B', '5'),
('False', 'False', '', '', 'Greenfield Builders', 'Eco Friendly Construction', 'https://img.freepik.com/vector-premium/logotipo-enlucido-construccion-diseno-ladrillo-paleta_501861-302.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'info@greenfield.com', '54', '911', '1568994786', 'Argentina', 'Buenos Aires', 'San Fernando', 'B1646', 'Perón', '345', '', '30', '34768495', '9', 'Efectivo', 'C', '6'),
('True', 'False', '', '', 'Urban Renovations', 'Urban Renewal Experts', '', 'info@urbanrenovations.com', '54', '911', '1558897263', 'Argentina', 'Buenos Aires', 'Tigre', 'B1648', 'Cazón', '768', '', '23', '29334857', '9', 'Cheque', 'A', '2'),
('True', 'True', 'Carlos', 'Berlinguieri', '', '', '', 'berlinguieric@gmail.com', '54', '911', '1557736789', 'Argentina', 'Buenos Aires', 'Pacheco', 'B1617', 'Santa Fé', '1290', '', '', '38274478', '', 'Efectivo', 'C', '1');

-- SUPPLIERS

CREATE TABLE suppliers(
Id int primary key identity,
ActiveStatus bit,
IsPerson bit,
FirstName varchar(30),
LastName varchar(30),
BusinessName varchar(30),
BusinessDescription varchar(30),
ImageUrl varchar(300),
Email varchar(30),
PhoneCountry int,
PhoneArea int,
PhoneNumber int,
AdressCountry varchar(30),
AdressProvince varchar(30),
AdressCity varchar(30),
AdressZipCode varchar(30),
AdressStreet varchar(30),
AdressStreetNumber int,
AdressFlat varchar(30),
LegalIdXX varchar(30),
LegalIdDNI int,
LegalIdY varchar(30),
PaymentMethod varchar(30),
InvoiceCategory varchar(30),
IsIndispensable bit
)

INSERT INTO suppliers
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, PaymentMethod, InvoiceCategory, IsIndispensable) VALUES
('True', 'True', '', '', 'Carlitos Construction', 'Construcción Argentina', '', 'carlitosconstruye@gmail.com', '54', '911', '1527863846', 'Argentina', 'Buenos Aires', 'CABA', 'C1000', '9 de Julio', '1290', '', '20', '37456776', '9', 'Crédito', 'C', 'False');

-- EMPLOYEES

CREATE TABLE employees(
EmployeeId int primary key identity,
ActiveStatus bit,
IsPerson bit,
FirstName varchar(30),
LastName varchar(30),
BusinessName varchar(30),
BusinessDescription varchar(30),
ImageUrl varchar(300),
Email varchar(30),
PhoneCountry int,
PhoneArea int,
PhoneNumber int,
AdressCountry varchar(30),
AdressProvince varchar(30),
AdressCity varchar(30),
AdressZipCode varchar(30),
AdressStreet varchar(30),
AdressStreetNumber int,
AdressFlat varchar(30),
LegalIdXX varchar(30),
LegalIdDNI int,
LegalIdY varchar(30),
Admission datetime default getdate() not null,
CategoryId int
)

INSERT INTO employees
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneCountry, PhoneArea, PhoneNumber, AdressCountry, AdressProvince, AdressCity, AdressZipCode, AdressStreet, AdressStreetNumber, AdressFlat, LegalIdXX, LegalIdDNI, LegalIdY, CategoryId) VALUES
('True', 'True', 'Federico', 'Bocca', 'Pisos Click', '', '', '', '0', '0', '0', 'Argentina', 'Buenos Aires', '', '', '', '0', '', '', '0', '', '1'),
('True', 'True', 'Gerbacio', 'Figueredo', 'Pisos Click', '', '', '', '0', '0', '0', 'Paraguay', '', '', '', '', '0', '', '', '0', '', '10');

-- CATEGORIES

CREATE TABLE categories(
Id int primary key identity,
Area varchar(30),
Title varchar(30),
Seniority varchar(30),
)

INSERT INTO categories
(Area, Title, Seniority) VALUES
('IT', 'Administrador de Sistemas', 'Semi Senior'),
('IT', 'Desarrollador', 'Junior'),
('IT', 'Desarrollador', 'Senior'),
('Ventas', 'Representante de ventas', 'Junior'),
('Ventas', 'Gerente de ventas', 'Senior'),
('RRHH', 'Analista de RRHH', 'Senior'),
('Marketing', 'Comuinity Manager', 'Junior'),
('Marketing', 'Gerente de Marketing', 'Senior'),
('Logística', 'Gerente de Logística', 'Semi Senior'),
('Producción', 'Operario', 'Semi Senior');

-- USERS

CREATE TABLE users(
UserId int primary key identity,
UserName varchar(30),
UserPassword varchar(30),
RoleId int
)

INSERT INTO users
(UserName, UserPassword, RoleId) VALUES
('Bocca1', 'estanopk', '1');

-- ROLES

CREATE TABLE roles(
Id int primary key identity,
RoleName varchar(30),
PermissionLevel int
)

INSERT INTO roles
(RoleName, PermissionLevel) VALUES
('Administrador', '5'),
('Ventas', '5'),
('Ventas', '4'),
('RRHH', '5'),
('RRHH', '3'),
('Logística', '5'),
('Logística', '2');

-- TESTING QUERIES

SELECT EmployeeId, FirstName, LastName, Admission, CategoryId, Area, Title, Seniority FROM employees E, categories C WHERE E.CategoryId = C.Id

SELECT EmployeeId, FirstName, LastName, UserName, UserPassword FROM employees E, users U WHERE U.UserName = concat(E.LastName, E.EmployeeId)

SELECT * FROM users

UPDATE users SET UserName = 'Bocca1' WHERE UserId = 1;

DELETE FROM employees WHERE EmployeeId = 6