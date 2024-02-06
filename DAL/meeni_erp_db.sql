-- DATABASE

CREATE DATABASE meeni_erp_db
GO

USE meeni_erp_db
GO

-- PHONES

CREATE TABLE phones(
PhoneId int primary key identity,
PhoneNumber int,
CountryId int,
ProvinceId int)

INSERT INTO phones
(PhoneNumber, CountryId, ProvinceId)
VALUES
('1527863846', '1', '1'),
('1547873654', '1', '1'),
('1568994786', '1', '1'),
('1558897263', '1', '1'),
('1557736789', '1', '1'),
('1527863846', '1', '1'),
('1547873654', '1', '1'),
('1558897263', '1', '1'),
('1557736789', '1', '1');


-- ADRESSES

CREATE TABLE adresses(
AdressId int primary key identity,
AdressCity varchar(30),
AdressZipCode varchar(30),
AdressStreetName varchar(30),
AdressStreetNumber int,
AdressFlat varchar(30),
CountryId int,
ProvinceId int)

INSERT INTO adresses
(AdressCity, AdressZipCode, AdressStreetName, AdressStreetNumber, AdressFlat, CountryId, ProvinceId)
VALUES
('CABA', 'C1000', '9 de Julio', '1290', '', '1', '1'),
('CABA', 'C1000', 'Córdoba', '2345', '9B', '1', '1'),
('San Fernando', 'B1646', 'Perón', '345', '', '1', '1'),
('Tigre', 'B1648', 'Cazón', '768', '', '1', '1'),
('Pacheco', 'B1617', 'Santa Fé', '1290', '', '1', '1'),
('CABA', 'C1000', '9 de Julio', '1290', '', '1', '1'),
('CABA', 'C1000', 'Córdoba', '2345', '9B', '1', '1'),
('San Fernando', 'B1646', 'Perón', '345', '', '1', '1'),
('Tigre', 'B1648', 'Cazón', '768', '', '1', '1'),
('Pacheco', 'B1617', 'Santa Fé', '1290', '', '1', '1'),
('Villa Adelina', '', 'Piedra Mala', '389', '2C', '1', '1');

-- TAXCODES

CREATE TABLE taxCodes(
TaxCodeId int primary key identity,
TaxCodePrefix varchar(30),
TaxCodeNumber int,
TaxCodeSuffix varchar(30))

INSERT INTO taxCodes
(TaxCodePrefix, TaxCodeNumber, TaxCodeSuffix)
VALUES
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
('23', '29334857', '9'),
('0', '38274478', '0'),
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
('0', '38274478', '0');

-- INDIVIDUALS

CREATE TABLE individuals(
IndividualId int primary key identity,
ActiveStatus bit,
IsPerson bit,
FirstName varchar(30),
LastName varchar(30),
BusinessName varchar(30),
BusinessDescription varchar(30),
ImageUrl varchar(300),
Email varchar(30),
PhoneId int,
AdressId int,
TaxCodeId int)

INSERT INTO individuals
(ActiveStatus, IsPerson, FirstName, LastName, BusinessName, BusinessDescription, ImageUrl, Email, PhoneId, AdressId, TaxCodeId)
VALUES
('True', 'False', '', '', 'Johnson Construction', 'Residential Contractor', 'https://img.freepik.com/vector-gratis/logotipo-empresa-construccion-diseno-plano_23-2150051909.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'info@johnsonconstruction.com', '1', '1', '1'),
('False', 'False', '', '', 'Smith Commercial', 'Comercial Developer', 'https://img.freepik.com/vector-gratis/logotipo-excavadora-construccion-edificios_23-2148657768.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'contact@smithcommercial.com', '2', '2', '2'),
('True', 'False', '', '', 'Greenfield Builders', 'Eco Friendly Construction', 'https://img.freepik.com/vector-premium/logotipo-enlucido-construccion-diseno-ladrillo-paleta_501861-302.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais', 'info@greenfield.com', '3', '3', '3'),
('True', 'True', 'Carlos', 'Berlinguieri', '', '', '', 'berlinguieric@gmail.com', '4', '4', '4'),
('True', 'False', '', '', 'Fierros Ratti', 'Hierros y herrajes', 'https://hierrosratti.com.ar/images/productos/tubos.jpg', 'contacto@hierrosratti.com.ar', '5', '5', '5'),
('True', 'True', 'Teodoro', 'Figueredo', '', 'Colocador', '', '', '6', '6', '6'),
('True', 'True', 'Federico', 'Bocca', 'Pisos Click', 'Pisos vinílicos', '', '', '7', '7', '7'),
('True', 'True', 'Mario', 'Santos', 'Pisos Click', 'Pisos vinílicos', '', '', '8', '8', '8'),
('False', 'True', 'Pablo', 'Lampone', 'Pisos Click', 'Pisos vinílicos', '', '', '9', '9', '9');


-- BUSINESS PARTNERS

CREATE TABLE businessPartners(
BusinessPartnerId int primary key identity,
PaymentMethod varchar(30),
InvoiceCategory varchar(30),
IndividualId int)

INSERT INTO businessPartners
(PaymentMethod, InvoiceCategory, IndividualId)
VALUES
('Efectivo', 'C', '1'),
('Efectivo', 'A', '2'),
('Débito', 'B', '3'),
('Transferencia', 'C', '4'),
('Transferencia', 'C', '5'),
('Efectivo', 'A', '6');

-- CUSTOMERS

CREATE TABLE customers(
CustomerId int primary key identity,
SalesAmount int,
BusinessPartnerId int)

INSERT INTO customers
(SalesAmount, BusinessPartnerId)
VALUES
('5', '1'),
('3', '2'),
('8', '3'),
('1', '4');

-- SUPPLIERS

CREATE TABLE suppliers(
SupplierId int primary key identity,
IsIndispensable bit,
BusinessPartnerId int)

INSERT INTO suppliers
(IsIndispensable, BusinessPartnerId)
VALUES
('True', '5'),
('False', '6');

-- SENIORITIES

CREATE TABLE seniorities(
SeniorityId int primary key identity,
SeniorityName varchar(30))

INSERT INTO seniorities
(SeniorityName)
VALUES
('Trainee'),
('Junior'),
('Semi Senior'),
('Senior');

-- DEPARTMENTS

CREATE TABLE departments(
DepartmentId int primary key identity,
DepartmentName varchar(30))

INSERT INTO departments
(DepartmentName)
VALUES
('IT'),
('Ventas'),
('RRHH'),
('Marketing'),
('Logística'),
('Producción');

-- POSITIONS

CREATE TABLE positions(
PositionId int primary key identity,
PositionTitle varchar(30),
SeniorityId int,
DepartmentId int)

INSERT INTO positions
(PositionTitle, SeniorityId, DepartmentId)
VALUES
('Administrador de Sistemas', '1', '3'),
('Desarrollador', '1', '2'),
('Desarrollador', '1', '4'),
('Representante de ventas', '2', '2'),
('Gerente de ventas', '2', '4'),
('Analista de RRHH', '3', '3'),
('Comuinity Manager', '4', '2'),
('Gerente de Marketing', '4', '3'),
('Gerente de Logística', '5', '4'),
('Operario', '6', '1');

-- EMPLOYEES

CREATE TABLE employees(
EmployeeId int primary key identity,
Admission datetime not null default getdate(),
PositionId int,
IndividualId int)

INSERT INTO employees
(PositionId, IndividualId)
VALUES
('5', '7'),
('1', '8'),
('9', '9');

-- ROLES

CREATE TABLE roles(
RoleId int primary key identity,
RoleName varchar(50))

INSERT INTO roles
(RoleName)
VALUES
('Acceso total'),
('Escritura en área y lectura total'),
('Lectoescritura en área'),
('Lectura total'),
('Solo lectura en área'),
('Solo lectura restringida');

-- USERS

CREATE TABLE users(
UserId int primary key identity,
UserName varchar(30),
UserPassword varchar(30),
RoleId int)

INSERT INTO users
(UserName, UserPassword, RoleId)
VALUES
('Bocca1', 'estanopk', '1');

-- WAREHOUSES

CREATE TABLE warehouses(
WarehouseId int primary key identity,
ActiveStatus bit,
WarehouseName varchar(30),
AdressId int)

INSERT INTO warehouses
(ActiveStatus, WarehouseName, AdressId)
VALUES
('True', 'Depósito de 197', '10'),
('False', 'Showroom Villa Adelina', '11');

-- QUERIES

SELECT * FROM employees

SELECT UserId, UserName, UserPassword, U.RoleId, RoleName FROM individuals I, employees E, users U, roles R WHERE U.UserName = concat(I.LastName, E.EmployeeId) AND U.RoleId = R.RoleId
