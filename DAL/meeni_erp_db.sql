create database meeni_erp_db
go

use meeni_erp_db
go

----------------
-- CURRENCIES --
----------------

create table Currencies(
	CurrencyId tinyint primary key identity(1,1) not null,
	Code varchar(3) unique check(len(trim(Code)) = 3) not null,
	CurrencyName varchar(30) not null,
	Rate decimal(15,2) not null,
	BlackRate decimal(15,2) null
)
go

insert into Currencies
(Code, CurrencyName, Rate, BlackRate)
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
	CountryId tinyint primary key identity(1,1) not null,
	CountryName varchar(30) unique not null,
	PhoneAreaCode int unique not null,
	CurrencyId tinyint foreign key references Currencies(CurrencyId) not null
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
	ProvinceId smallint primary key identity(1,1) not null,
	ProvinceName varchar(30) not null,
	PhoneAreaCode int not null,
	CountryId tinyint foreign key references Countries(CountryId) not null
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
	CityId smallint primary key identity(1,1) not null,
	CityName varchar(30) not null,
	ZipCode varchar(30) null,
	ProvinceId smallint foreign key references Provinces(ProvinceId) not null
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

--------------
-- TAXCODES --
--------------

create table TaxCodes(
	TaxCodeId int primary key identity(1,1) not null,
	Prefix varchar(10) null,
	Number int not null,
	Suffix varchar(10) null
)
go

insert into TaxCodes
(Prefix, Number, Suffix)
values
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
('20', '37456776', '9'),
('20', '20378846', '3'),
('30', '34768495', '9'),
(null, '29334857', null),
(null, '38274478', null);
go

--------------
-- ADRESSES --
--------------

create table Adresses(
	AdressId int primary key identity(1,1) not null,
	StreetName varchar(30) not null,
	StreetNumber int not null,
	Flat varchar(30) null,
	Details varchar(300) null,
	CityId smallint foreign key references Cities(CityId) not null
)
go

insert into Adresses
(StreetName, StreetNumber, Flat, Details, CityId)
values
('Piedra Buena', '389', '2C', 'En frente de las vías', '2'),
('9 de Julio', '1290', '2C', 'No anda el timbre', '1'),
('Córdoba', '2345', '9B', 'Puerta roja', '1'),
('Perón', '345', '', '', '4'),
('Cazón', '768', '', '', '5'),
('Santa Fé', '1290', '', '', '3');
go

------------
-- PHONES --
------------

create table Phones(
	PhoneId int primary key identity(1,1) not null,
	Number int not null,
	ProvinceId smallint foreign key references Provinces(ProvinceId) not null
)
go

insert into Phones
(Number, ProvinceId)
values
('1527863846', '1'),
('1547873654', '1'),
('1568994786', '1'),
('1558897263', '1'),
('1557736789', '1');
go

------------
-- PEOPLE --
------------

create table People(
	PersonId int primary key identity(1,1) not null,
	FirstName varchar(30) not null,
	LastName varchar(30) not null,
)
go

insert into People
(FirstName, LastName)
values
('Federico', 'Bocca'),
('Carlos', 'Berlinguieri'),
('Teodoro', 'Figueredo');
go

-------------------
-- ORGANIZATIONS --
-------------------

create table Organizations(
	OrganizationId int primary key identity(1,1) not null,
	OrganizationName varchar(30) unique not null,
	OrganizationDescription varchar(50) null
)
go

insert into Organizations
(OrganizationName, OrganizationDescription)
values
('Pisos Click', 'Pisos vinílicos'),
('Johnson Construction', null),
('Smith Commercial', 'Comercial Developer'),
('Greenfield Builders', 'Eco Friendly Construction'),
('Fierros Ratti', null),
('Herrajes San Martín', 'Herrajes de todo tipo');
go

-----------
-- ITEMS --
-----------

create table Items(
	ItemId int primary key identity(1,1) not null
)
go

--------------
-- PRODUCTS --
--------------

create table Products(
	ProductId int primary key identity(1,1) not null,
	ItemId int foreign key references Items(ItemId) not null
)
go

--------------
-- SERVICES --
--------------

create table Services(
	ServiceId int primary key identity(1,1) not null,
	ItemId int foreign key references Items(ItemId) not null
)
go

------------
-- IMAGES --
------------

create table Images(
	ImageId int primary key identity(1,1) not null,
	ImageUrl varchar(300) unique not null
)
go

insert into Images
(ImageUrl)
values
('https://img.freepik.com/vector-gratis/logotipo-empresa-construccion-diseno-plano_23-2150051909.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
('https://img.freepik.com/vector-gratis/logotipo-excavadora-construccion-edificios_23-2148657768.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
('https://img.freepik.com/vector-premium/logotipo-enlucido-construccion-diseno-ladrillo-paleta_501861-302.jpg?size=338&ext=jpg&ga=GA1.1.1412446893.1705449600&semt=ais'),
('https://hierrosratti.com.ar/images/productos/tubos.jpg'),
('https://www.herrajessanmartin.com/Pubs/Sites/Default/Config/logo-hsm-invertido-02.png'),
('https://img.freepik.com/foto-gratis/chico-guapo-seguro-posando-contra-pared-blanca_176420-32936.jpg?size=626&ext=jpg&ga=GA1.1.1224184972.1708992000&semt=sph');
go

---------------------------
-- IMAGE-PERSON RELATION --
---------------------------

create table ImagePersonRelations(
	ImageId int foreign key references Images(ImageId) not null,
	PersonId int foreign key references People(PersonId) not null
)
go

---------------------------------
-- IMAGE-ORGANIZATION RELATION --
---------------------------------

create table ImageOrganizationRelations(
	ImageId int foreign key references Images(ImageId) not null,
	OrganizationId int foreign key references Organizations(OrganizationId) not null
)
go

insert into ImageOrganizationRelations
(ImageId, OrganizationId)
values
(1,2),
(2,3),
(3,4);

----------------------------
-- IMAGE-PRODUCT RELATION --
----------------------------

create table ImageProductRelations(
	ImageId int foreign key references Images(ImageId) not null,
	ProductId int foreign key references Products(ProductId) not null
)
go

-----------------
-- INDIVIDUALS --
-----------------

create table Individuals(
	IndividualId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	Email varchar(30) null,
	Birth date null,
	TaxCodeId int foreign key references TaxCodes(TaxCodeId) null,
	AdressId int foreign key references Adresses(AdressId) null,
	PhoneId int foreign key references Phones(PhoneId) null,
	PersonId int foreign key references People(PersonId) null,
	OrganizationId int foreign key references Organizations(OrganizationId) null,
	Constraint UC_Person_Organization unique (PersonId, OrganizationId)
)
go

insert into Individuals
(ActiveStatus, Email, Birth, TaxCodeId, AdressId, PhoneId, PersonId, OrganizationId)
values
('true', 'pisosclick@gmail.com', '2019-01-26', '1', '1', null, '1', '1'),
('true', 'johnsonconst@gmail.com', null, '2', '2', null, null, '2'),
('true', 'contact@smithcommercial.com', null, '3', '3', '1', null, '3'),
('false', 'info@greenfield.com', null, '4', '4', null, null, '4'),
('true', 'contacto@hierrosratti.com.ar', null, '5', '5', '2', null, '5'),
('true', 'contacto@hsm.com.ar', null, '6', '6', '3', null, '6'),
('false', 'berlinguieric@gmail.com', '1987-05-12', '7', null, '4', '2', null),
('true', null, '1985-06-18', '8', null, '5', '3', null);
go

-----------------------
-- BUSINESS PARTNERS --
-----------------------

create table BusinessPartners(
	BusinessPartnerId int primary key identity(1,1) not null,
	PaymentMethod varchar(30) null,
	InvoiceCategory varchar(30) null,
	IndividualId int foreign key references Individuals(IndividualId) not null
)
go

insert into BusinessPartners
(PaymentMethod, InvoiceCategory, IndividualId)
values
('Efectivo', 'C', '2'),
('Efectivo', 'A', '3'),
('Débito', 'B', '4'),
('Transferencia', 'C', '5'),
('Efectivo', 'A', '6');
go

---------------
-- CUSTOMERS --
---------------

create table Customers(
	CustomerId int primary key identity(1,1) not null,
	SalesAmount int null,
	BusinessPartnerId int foreign key references BusinessPartners(BusinessPartnerId) not null
)
go

insert into Customers
(SalesAmount, BusinessPartnerId)
values
('5', '1'),
('3', '2'),
('8', '3');
go

---------------
-- SUPPLIERS --
---------------

create table Suppliers(
	SupplierId int primary key identity(1,1) not null,
	IsIndispensable bit not null default(0),
	BusinessPartnerId int foreign key references BusinessPartners(BusinessPartnerId) not null
)
go

insert into Suppliers
(IsIndispensable, BusinessPartnerId)
values
('true', '4'),
('false', '5');
go

-----------------
-- SENIORITIES --
-----------------

create table Seniorities(
	SeniorityId tinyint primary key identity(1,1) not null,
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

-----------------
-- DEPARTMENTS --
-----------------

create table Departments(
	DepartmentId tinyint primary key identity(1,1) not null,
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

---------------
-- POSITIONS --
---------------

create table Positions(
	PositionId smallint primary key identity(1,1) not null,
	PositionTitle varchar(30) not null,
	SeniorityId tinyint foreign key references Seniorities(SeniorityId) not null,
	DepartmentId tinyint foreign key references Departments(DepartmentId) not null
)
go

insert into Positions
(PositionTitle, SeniorityId, DepartmentId)
values
('Administrador de Sistemas', '3', '1'),
('Desarrollador', '2', '1'),
('Desarrollador', '4', '1'),
('Representante de ventas', '2', '2'),
('Gerente de ventas', '4', '2'),
('Analista de RRHH', '3', '3'),
('Comuinity Manager', '2', '4'),
('Gerente de Marketing', '3', '4'),
('Gerente de Logística', '4', '5'),
('Operario', '1', '6');
go

---------------
-- EMPLOYEES --
---------------

create table Employees(
	EmployeeId int primary key identity(1,1) not null,
	Admission datetime not null default getdate(),
	PositionId smallint foreign key references Positions(PositionId) not null,
	IndividualId int foreign key references Individuals(IndividualId) not null
)
go

insert into Employees
(PositionId, IndividualId)
values
('5', '1'),
('10', '7'),
('10', '8');
go

-----------
-- ROLES --
-----------

create table Roles(
	RoleId tinyint primary key identity(1,1) not null,
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

-----------
-- USERS --
-----------

create table Users(
	UserId int primary key identity(1,1) not null,
	UserName varchar(30) not null,
	UserPassword varchar(30) not null,
	RoleId tinyint foreign key references Roles(RoleId) not null,
	EmployeeId int foreign key references Employees(EmployeeId) not null
)
go

insert into Users
(UserName, UserPassword, RoleId, EmployeeId)
values
('fedebocca97', 'estanopk', '1', '1'),
('bercar2000', '2368', '4', '2');
go

----------------
-- WAREHOUSES --
----------------

create table Warehouses(
	WarehouseId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	WarehouseName varchar(30) not null,
	AdressId int foreign key references Adresses(AdressId) null
)
go

insert into Warehouses
(ActiveStatus, WarehouseName, AdressId)
values
('true', 'Depósito de 197', '6'),
('false', 'Showroom Villa Adelina', '1');
go
