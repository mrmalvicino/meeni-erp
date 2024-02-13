--------------
-- DATABASE --
--------------

create database meeni_erp_db
go

use meeni_erp_db
go

----------------
-- CURRENCIES --
----------------

create table Currencies(
	CurrencyId int primary key identity(1,1) not null,
	CurrencyCode varchar(3) unique check(len(trim(CurrencyCode)) = 3) not null,
	CurrencyName varchar(30) not null,
	CurrencyRate decimal(15,2) not null,
	CurrencyBlackRate decimal(15,2) null
)
go

insert into Currencies
(CurrencyCode, CurrencyName, CurrencyRate, CurrencyBlackRate)
values
('USD', 'Dólar', '1', '1'),
('EUR', 'Euro', '0.93', '0.93'),
('ARS', 'Peso', '830', '1130'),
('BRL', 'Real', '5', '5');
go

---------------
-- COUNTRIES --
---------------

create table Countries(
	CountryId int primary key identity(1,1) not null,
	CountryName varchar(30) unique not null,
	PhoneAreaCode int unique not null,
	CurrencyId int foreign key references Currencies(CurrencyId) not null
)
go

insert into Countries
(CountryName, PhoneAreaCode, CurrencyId)
values
('Argentina', '54', '3'),
('Estados Unidos', '1', '1'),
('España', '34', '2'),
('Brasil', '55', '4');
go

---------------
-- PROVINCES --
---------------

create table Provinces(
	ProvinceId int primary key identity(1,1) not null,
	ProvinceName varchar(30) not null,
	PhoneAreaCode int not null,
	CountryId int foreign key references Countries(CountryId) not null
)
go

insert into Provinces
(ProvinceName, PhoneAreaCode, CountryId)
values
('Buenos Aires', '911', '1'),
('Córdoba', '351', '1'),
('Río Negro', '02920', '1');
go

------------
-- CITIES --
------------

create table Cities(
	CityId int primary key identity(1,1) not null,
	CityName varchar(30) not null,
	ZipCode varchar(30) null,
	ProvinceId int foreign key references Provinces(ProvinceId) not null
)
go

insert into Cities
(CityName, ZipCode, ProvinceId)
values
('CABA', '1000', '1'),
('Villa Adelina', '1607', '1'),
('General Pacheco', '1617', '1'),
('San Fernando', '1646', '1'),
('Tigre', '1648', '1'),
('Don Torcuato', '1617', '1'),
('Villa Carlos Paz', '5152', '2'),
('San Carlos de Bariloche', '8400', '3');
go

------------
-- PHONES --
------------

create table Phones(
	PhoneId int primary key identity(1,1) not null,
	PhoneNumber int not null,
	ProvinceId int foreign key references Provinces(ProvinceId) null
)
go

insert into Phones
(PhoneNumber, ProvinceId)
values
('1527863846', '1'),
('1547873654', '1'),
('1568994786', '1'),
('1558897263', '1'),
('1557736789', '1'),
('1527863846', '1'),
('1547873654', '1'),
('1558897263', '2'),
('1557736789', '3');
go

--------------
-- ADRESSES --
--------------

create table Adresses(
	AdressId int primary key identity(1,1) not null,
	AdressStreetName varchar(30) not null,
	AdressStreetNumber int not null,
	AdressFlat varchar(30) null,
	CityId int foreign key references Cities(CityId) not null
)
go

insert into Adresses
(AdressStreetName, AdressStreetNumber, AdressFlat, CityId)
values
('9 de Julio', '1290', '', '1'),
('Córdoba', '2345', '9B', '1'),
('Perón', '345', '', '4'),
('Cazón', '768', '', '5'),
('Santa Fé', '1290', '', '3'),
('Piedra Buena', '389', '2C', '2');
go

--------------
-- TAXCODES --
--------------

create table TaxCodes(
	TaxCodeId int primary key identity(1,1) not null,
	TaxCodePrefix varchar(10) null,
	TaxCodeNumber int not null,
	TaxCodeSuffix varchar(10) null
)
go

insert into TaxCodes
(TaxCodePrefix, TaxCodeNumber, TaxCodeSuffix)
values
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
('0', '29334857', '0'),
('0', '38274478', '0'),
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
('0', '38274478', '0');
go

------------
-- IMAGES --
------------

create table Images(
	ImageId int primary key identity(1,1) not null,
	PersonId int null,
	OrganizationId int null,
	ProductId int null,
	ImageUrl varchar(300) unique not null
)
go

insert into Images
(PersonId, OrganizationId, ProductId, ImageUrl)
values
(null, null, null, 'https://img.freepik.com/vector-gratis/logotipo-empresa-construccion-diseno-plano_23-2150051909.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
(null, null, null, 'https://img.freepik.com/vector-gratis/logotipo-excavadora-construccion-edificios_23-2148657768.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
(null, null, null, 'https://img.freepik.com/vector-premium/logotipo-enlucido-construccion-diseno-ladrillo-paleta_501861-302.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
(null, null, null, 'https://hierrosratti.com.ar/images/productos/tubos.jpg');
go

------------
-- PEOPLE --
------------

create table People(
	PersonId int primary key identity(1,1) not null,
	FirstName varchar(30) not null,
	LastName varchar(30) not null,
	Birth date null,
	Email varchar(30) null,
	TaxCodeId int foreign key references TaxCodes(TaxCodeId) null,
	AdressId int foreign key references Adresses(AdressId) null,
	PhoneId int foreign key references Phones(PhoneId) null,
)
go

insert into People
(FirstName, LastName, Birth, Email, TaxCodeId, AdressId, PhoneId)
values
('Federico', 'Bocca', '1997-01-26', null, '11', '11', '11'),
('Carlos', 'Berlinguieri', '1987-05-12', 'berlinguieric@gmail.com', '4', '4', '4'),
('Teodoro', 'Figueredo', '1985-06-18', null, '6', '6', '6'),
('Mario', 'Santos', '1992-10-18', null, '8', '8', '8'),
('Pablo', 'Lampone', '1990-09-14', null, '9', '9', '9');
go

-------------------
-- ORGANIZATIONS --
-------------------

create table Organizations(
	OrganizationId int primary key identity(1,1) not null,
	OrganizationName varchar(30) unique not null,
	OrganizationDescription varchar(50) null,
	Birth date null,
	Email varchar(30) null,
	TaxCodeId int foreign key references TaxCodes(TaxCodeId) null,
	AdressId int foreign key references Adresses(AdressId) null,
	PhoneId int foreign key references Phones(PhoneId) null,
)
go

insert into Organizations
(OrganizationName, OrganizationDescription, Birth, Email, TaxCodeId, AdressId, PhoneId)
values
('Pisos Click', 'Pisos vinílicos', null, null, null, null, null),
('Johnson Construction', 'Residential Contractor', null, 'info@johnsonconstruction.com', '1', '1', '1'),
('Smith Commercial', 'Comercial Developer', null, 'contact@smithcommercial.com', '2', '2', '2'),
('Greenfield Builders', 'Eco Friendly Construction', null, 'info@greenfield.com', '3', '3', '3'),
('Fierros Ratti', 'Hierros y herrajes', null, 'contacto@hierrosratti.com.ar', '5', '5', '5');
go

-----------------
-- INDIVIDUALS --
-----------------

create table Individuals(
	ActiveStatus bit not null default(1),
	PersonId int foreign key references People(PersonId) not null,
	OrganizationId int foreign key references Organizations(OrganizationId) not null,
	primary key (PersonId, OrganizationId)
)
go

insert into Individuals
(ActiveStatus, PersonId, OrganizationId)
values
('True', '1', '1'),
('True', '0', '2'),
('False', '0', '3'),
('True',  '0', '4'),
('True', '2', '0'),
('True', '0', '5'),
('True', '3', '0'),
('True', '4', '0'),
('True', '5', '0');
go

-----------------------
-- BUSINESS PARTNERS --
-----------------------

create table BusinessPartners(
	BusinessPartnerId int primary key identity(1,1) not null,
	PaymentMethod varchar(30) null,
	InvoiceCategory varchar(30) null,
	PersonId int not null,
	OrganizationId int not null,
	foreign key (PersonId, OrganizationId) references Individuals(PersonId, OrganizationId)
)
go

insert into BusinessPartners
(PaymentMethod, InvoiceCategory, IndividualId)
values
('Efectivo', 'C', '1'),
('Efectivo', 'A', '2'),
('Débito', 'B', '3'),
('Transferencia', 'C', '4'),
('Transferencia', 'C', '5'),
('Efectivo', 'A', '6');
go

-- CUSTOMERS

create table Customers(
	CustomerId int primary key identity(1,1) not null,
	SalesAmount int null,
	BusinessPartnerId int not null
)
go

insert into Customers
(SalesAmount, BusinessPartnerId)
values
('5', '1'),
('3', '2'),
('8', '3'),
('1', '4');
go

-- SUPPLIERS

create table Suppliers(
	SupplierId int primary key identity(1,1) not null,
	IsIndispensable bit not null default(0),
	BusinessPartnerId int not null
)
go

insert into Suppliers
(IsIndispensable, BusinessPartnerId)
values
('True', '5'),
('False', '6');
go

-- SENIORITIES

create table Seniorities(
	SeniorityId int primary key identity(1,1) not null,
	SeniorityName varchar(30) not null
)
go

insert into Seniorities
(SeniorityName)
values
('Trainee'),
('Junior'),
('Semi Senior'),
('Senior');
go

-- DEPARTMENTS

create table Departments(
	DepartmentId int primary key identity(1,1) not null,
	DepartmentName varchar(30) not null
)
go

insert into Departments
(DepartmentName)
values
('IT'),
('Ventas'),
('RRHH'),
('Marketing'),
('Logística'),
('Producción');
go

-- POSITIONS

create table Positions(
	PositionId int primary key identity(1,1) not null,
	PositionTitle varchar(30) not null,
	SeniorityId int not null,
	DepartmentId int not null
)
go

insert into Positions
(PositionTitle, SeniorityId, DepartmentId)
values
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
go

-- EMPLOYEES

create table Employees(
	EmployeeId int primary key identity(1,1) not null,
	Admission datetime not null default getdate(),
	PositionId int not null,
	IndividualId int not null
)
go

insert into Employees
(PositionId, IndividualId)
values
('5', '7'),
('1', '8'),
('9', '9');
go

-- ROLES

create table Roles(
	RoleId int primary key identity(1,1) not null,
	RoleName varchar(50) not null
)
go

insert into Roles
(RoleName)
values
('Acceso total'),
('Escritura en área y lectura total'),
('Lectoescritura en área'),
('Lectura total'),
('Solo lectura en área'),
('Solo lectura restringida');
go

-- USERS

create table Users(
	UserId int primary key identity(1,1) not null,
	UserName varchar(30) not null,
	UserPassword varchar(30) not null,
	RoleId int not null
)
go

insert into Users
(UserName, UserPassword, RoleId)
values
('Bocca1', 'estanopk', '1');
go

-- WAREHOUSES

create table Warehouses(
	WarehouseId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	WarehouseName varchar(30) not null,
	AdressId int null
)
go

insert into Warehouses
(ActiveStatus, WarehouseName, AdressId)
values
('True', 'Depósito de 197', '10'),
('False', 'Showroom Villa Adelina', '11');
go

-- JOINED QUERY EXAMPLE

SELECT C.CustomerId, C.SalesAmount, B.PaymentMethod, B.InvoiceCategory,
I.ActiveStatus, I.IsPerson, I.FirstName, I.LastName, I.BusinessName, I.BusinessDescription, I.ImageUrl, I.Email,
CO.CountryPhoneAreaCode, PR.ProvincePhoneAreaCode, P.PhoneNumber,
Co.CountryName, PR.ProvinceName, A.AdressCity, A.AdressZipCode, A.AdressStreetName, A.AdressStreetNumber, A.AdressFlat,
T.TaxCodePrefix, T.TaxCodeNumber, T.TaxCodeSuffix

FROM Customers C, BusinessPartners B, Individuals I, Phones P, Adresses A, TaxCodes T, Countries CO, Provinces PR, Currencies CU

WHERE C.BusinessPartnerId = B.BusinessPartnerId
AND B.IndividualId = I.IndividualId
AND I.PhoneId = P.PhoneId
AND I.AdressId = A.AdressId
AND I.TaxCodeId = T.TaxCodeId
AND A.CountryId = CO.CountryId
AND A.ProvinceId = PR.ProvinceId
AND CO.CurrencyId = CU.CurrencyId
go

-- TESTING QUERIES

SELECT * FROM Individuals
go