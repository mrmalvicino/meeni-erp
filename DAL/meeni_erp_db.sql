create database meeni_erp_db
collate Latin1_General_100_CI_AS_SC_UTF8;
go

use meeni_erp_db
go

----------------
-- CATEGORIES --
----------------

create table Categories(
	CategoryId int primary key identity(1,1) not null,
	CategoryName varchar(30) unique not null
)
go

insert into Categories
(CategoryName)
values
('Zócalo'),
('Piso vinílico'),
('Sellador'),
('Flete'),
('Colocación');
go

------------
-- BRANDS --
------------

create table Brands(
	BrandId int primary key identity(1,1) not null,
	BrandName varchar(30) unique not null
)
go

insert into Brands
(BrandName)
values
('Boden Design'),
('Harte Flooring'),
('Fastix');
go

------------
-- MODELS --
------------

create table Models(
	ModelId int primary key identity(1,1) not null,
	ModelName varchar(100) not null,
	BrandId int foreign key references Brands(BrandId) not null,
	constraint UC_Model unique (ModelName, BrandId)
)
go

insert into Models
(ModelName, BrandId)
values
('Prepintado Blanco 7,5cm MDF tira 2m', '1'),
('Roble oscuro SCP 5mm caja 10u', '2'),
('Transparente 25g', '3');
go

-----------
-- ITEMS --
-----------

create table Items(
	ItemId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	Price decimal(15,2) not null,
	Cost decimal(15,2) not null Default(0),
	CategoryId int foreign key references Categories(CategoryId) not null
)
go

insert into Items
(Price, Cost, CategoryId)
values
('15000', '14000', '1'),
('50000', '50000', '2'),
('5000', '5000', '3'),
('40000', '40000', '4'),
('60000', '60000', '4'),
('30000', '30000', '5');
go

--------------
-- PRODUCTS --
--------------

create table Products(
	ProductId int primary key identity(1,1) not null,
	ModelId int foreign key references Models(ModelId) unique not null,
	ItemId int foreign key references Items(ItemId) unique not null
)
go

insert into Products
(ModelId, ItemId)
values
('1', '1'),
('2', '2'),
('3', '3');
go

--------------
-- SERVICES --
--------------

create table Services(
	ServiceId int primary key identity(1,1) not null,
	Details varchar(100) unique not null,
	ItemId int foreign key references Items(ItemId) not null
)
go

insert into Services
(Details, ItemId)
values
('Zona norte ida y vuelta', '4'),
('CABA Ida y vuelta', '5'),
('Piso de hasta 20 m2', '6');
go

---------------
-- COUNTRIES --
---------------

create table Countries(
	CountryId tinyint primary key identity(1,1) not null,
	CountryName varchar(30) unique not null
)
go

insert into Countries
(CountryName)
values
('Argentina'),
('Estados Unidos'),
('España'),
('Brasil');
go

---------------
-- PROVINCES --
---------------

create table Provinces(
	ProvinceId smallint primary key identity(1,1) not null,
	ProvinceName varchar(30) not null,
	CountryId tinyint foreign key references Countries(CountryId) not null,
	constraint UC_Province unique (ProvinceName, CountryId)
)
go

insert into Provinces
(ProvinceName, CountryId)
values
('Buenos Aires', '1'),
('Córdoba', '1'),
('Río Negro', '1');
go

------------
-- CITIES --
------------

create table Cities(
	CityId smallint primary key identity(1,1) not null,
	CityName varchar(30) not null,
	ZipCode varchar(30) null,
	ProvinceId smallint foreign key references Provinces(ProvinceId) not null,
	constraint UC_City unique (CityName, ProvinceId)
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
-- ADRESSES --
--------------

create table Adresses(
	AdressId int primary key identity(1,1) not null,
	StreetName varchar(30) not null,
	StreetNumber varchar(10) not null,
	Flat varchar(30) null,
	Details varchar(300) null,
	CityId smallint foreign key references Cities(CityId) not null,
	constraint UC_Adress unique (StreetName, StreetNumber, CityId)
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

----------------
-- WAREHOUSES --
----------------

create table Warehouses(
	WarehouseId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	WarehouseName varchar(30) unique not null,
	AdressId int foreign key references Adresses(AdressId) not null
)
go

insert into Warehouses
(ActiveStatus, WarehouseName, AdressId)
values
('true', 'Depósito de 197', '6'),
('false', 'Showroom Villa Adelina', '1');
go

------------------
-- COMPARTMENTS --
------------------

create table Compartments(
	CompartmentId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	CompartmentName varchar(30) not null,
	Stock int check(0 <= Stock) not null default(0),
	ProductId int foreign key references Products(ProductId) not null,
	WarehouseId int foreign key references Warehouses(WarehouseId) not null,
	constraint UC_Compartment unique (CompartmentName, WarehouseId)
)
go

insert into Compartments
(ActiveStatus, CompartmentName, Stock, ProductId, WarehouseId)
values
('true', 'Primer Estante', '1', '1', '1'),
('true', 'Segundo Estante', '2', '2', '1'),
('true', 'Primer Estante', '3', '1', '2'),
('false', 'Segundo Estante', '4', '3', '2');
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
('https://img.freepik.com/foto-gratis/chico-guapo-seguro-posando-contra-pared-blanca_176420-32936.jpg?size=626&ext=jpg&ga=GA1.1.1224184972.1708992000&semt=sph'),
('https://www.atrimglobal.com.ar/wp-content/uploads/2016/08/Zocalo-Plain-2310.jpg'),
('https://http2.mlstatic.com/D_NQ_NP_948343-MLA51717745562_092022-O.jpg'),
('https://arcencohogar.vtexassets.com/arquivos/ids/274900/1054642.jpg?v=637651585258230000');
go

-----------------------------
-- IMAGE-PRODUCT RELATIONS --
-----------------------------

create table ImageProductRelations(
	ImageId int foreign key references Images(ImageId) not null,
	ProductId int foreign key references Products(ProductId) not null,
	primary key (ImageId, ProductId)
)
go

insert into ImageProductRelations
(ImageId, ProductId)
values
('7', '1'),
('8', '2'),
('9', '3');
go

--------------
-- TAXCODES --
--------------

create table TaxCodes(
	TaxCodeId int primary key identity(1,1) not null,
	Prefix varchar(10) null,
	Number varchar(20) unique not null,
	Suffix varchar(10) null
)
go

insert into TaxCodes
(Prefix, Number, Suffix)
values
('20', '37455376', '9'),
('20', '20288746', '3'),
('30', '34468435', '9'),
('20', '37196796', '9'),
('20', '20878716', '3'),
('30', '34726195', '9'),
(null, '29383857', null),
(null, '38474878', null);
go

------------
-- PEOPLE --
------------

create table People(
	PersonId int primary key identity(1,1) not null,
	FirstName varchar(30) not null,
	LastName varchar(30) not null,
	constraint UC_Person unique (FirstName, LastName)
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

-----------------
-- INDIVIDUALS --
-----------------

create table Individuals(
	IndividualId int primary key identity(1,1) not null,
	ActiveStatus bit not null default(1),
	Phone varchar(30) null,
	Email varchar(30) null,
	Birth date null,
	TaxCodeId int foreign key references TaxCodes(TaxCodeId) null,
	AdressId int foreign key references Adresses(AdressId) null,
	PersonId int foreign key references People(PersonId) null,
	OrganizationId int foreign key references Organizations(OrganizationId) null,
	ImageId int foreign key references Images(ImageId) null,
	constraint UC_Person_Organization unique (PersonId, OrganizationId)
)
go

insert into Individuals
(ActiveStatus, Phone, Email, Birth, TaxCodeId, AdressId, PersonId, OrganizationId, ImageId)
values
('true', null, 'pisosclick@gmail.com', '2019-01-26', '1', '1', '1', '1', null),
('true', null, 'johnsonconst@gmail.com', null, '2', '2', null, '2', '1'),
('true', '1189873789', 'contact@smithcommercial.com', null, '3', '3', null, '3', '2'),
('false', null, 'info@greenfield.com', null, '4', '4', null, '4', '3'),
('true', null, 'contacto@hierrosratti.com.ar', null, '5', '5', null, '5', '4'),
('true', null, 'contacto@hsm.com.ar', null, '6', '6', null, '6', '5'),
('false', null, 'berlinguieric@gmail.com', '1987-05-12', '7', null, '2', null, '6'),
('true', null, null, '1985-06-18', '8', null, '3', null, null);
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
	BusinessPartnerId int foreign key references BusinessPartners(BusinessPartnerId) not null
)
go

insert into Customers
(BusinessPartnerId)
values
('1'),
('2'),
('3');
go

---------------
-- SUPPLIERS --
---------------

create table Suppliers(
	SupplierId int primary key identity(1,1) not null,
	BusinessPartnerId int foreign key references BusinessPartners(BusinessPartnerId) not null
)
go

insert into Suppliers
(BusinessPartnerId)
values
('4'),
('5');
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

------------
-- QUOTES --
------------

create table Quotes(
	QuoteId int primary key identity(1,1) not null,
	ActiveStatus varchar(20) default('Cotizado') not null,
	VariantVersion tinyint default('1') not null,
	JobDate datetime default(getdate()) not null,
	CustomerId int foreign key references Customers(CustomerId) not null,
	constraint UC_Quote unique (VariantVersion, JobDate, CustomerId)
)
go

insert into Quotes
(ActiveStatus, VariantVersion, JobDate, CustomerId)
values
('Cotizado', '1', '2024-04-06', '1'),
('Rechazado', '1', '2024-04-13', '3');
go

----------------
-- QUOTE ROWS --
----------------

create table QuoteRows(
	QuoteRowId int primary key identity(1,1) not null,
	Amount smallint check(0 < Amount) not null,
	RowDescription varchar(100) not null,
	Price decimal(15,2) not null,
	ProductId int foreign key references Products(ProductId) null,
	ServiceId int foreign key references Services(ServiceId) null,
	constraint UC_Row unique (Amount, ProductId, ServiceId)
)
go

insert into QuoteRows
(Amount, RowDescription, Price, ProductId, ServiceId)
values
('1', 'Sellador Fastix Transparente 25g', '4900', '3', null),
('3', 'Piso vinílico Harte Flooring Roble oscuro SCP 5mm caja 10u', '49000', '2', null),
('3', 'Zócalo Boden Design Prepintado Blanco 7,5cm MDF tira 2m', '14000', '1', null),
('1', 'Flete Zona norte ida y vuelta', '39000', null, '1'),
('1', 'Colocación Piso de hasta 20 m2', '29000', null, '3'),
('2', 'Sellador Fastix Transparente 25g', '4900', '3', null),
('6', 'Piso vinílico Harte Flooring Roble oscuro SCP 5mm caja 10u', '49000', '2', null),
('6', 'Zócalo Boden Design Prepintado Blanco 7,5cm MDF tira 2m', '14000', '1', null),
('1', 'Flete CABA Ida y vuelta', '59000', null, '2');
go

-------------------------
-- ROW-QUOTE RELATIONS --
-------------------------

create table QuoteRowQuoteRelations(
	QuoteRowId int foreign key references QuoteRows(QuoteRowId) not null,
	QuoteId int foreign key references Quotes(QuoteId) not null,
	RowIndex tinyint not null
)
go

insert into QuoteRowQuoteRelations
(QuoteRowId, QuoteId, RowIndex)
values
('1', '1', '0'),
('2', '1', '1'),
('3', '1', '2'),
('4', '1', '3'),
('5', '1', '4'),
('6', '2', '0'),
('7', '2', '1'),
('8', '2', '2'),
('9', '2', '3'),
('5', '2', '4');
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