use meeni_erp_db;

go
---------------
-- COUNTRIES --
---------------
print '';

print 'Inserting initial data into countries table...';

go
insert into
    countries (name)
values
    ('Afganistán'),
    ('Albania'),
    ('Alemania'),
    ('Andorra'),
    ('Angola'),
    ('Antigua y Barbuda'),
    ('Arabia Saudita'),
    ('Arctic Ocean'),
    ('Argentina'),
    ('Armenia'), -- 10
    ('Australia'),
    ('Austria'),
    ('Azerbaiyán'),
    ('Bahamas'),
    ('Bangladesh'),
    ('Barbados'),
    ('Baréin'),
    ('Bélgica'),
    ('Belice'),
    ('Benín'), -- 20
    ('Bhután'),
    ('Bielorrusia'),
    ('Birmania'),
    ('Bolivia'),
    ('Bosnia y Herzegovina'),
    ('Botsuana'),
    ('Brasil'),
    ('Brunéi'),
    ('Bulgaria'),
    ('Burkina Faso'), -- 30
    ('Burundi'),
    ('Bután'),
    ('Cabo Verde'),
    ('Camboya'),
    ('Camerún'),
    ('Canadá'),
    ('Catar'),
    ('Chad'),
    ('Chile'),
    ('China'), -- 40
    ('Chipre'),
    ('Colombia'),
    ('Comoras'),
    ('Congo'),
    ('Corea del Norte'),
    ('Corea del Sur'),
    ('Costa Rica'),
    ('Croacia'),
    ('Cuba'),
    ('Curazao'), -- 50
    ('Dinamarca'),
    ('Dominica'),
    ('Ecuador'),
    ('Egipto'),
    ('El Salvador'),
    ('Emiratos Árabes Unidos'),
    ('Eritrea'),
    ('Eslovaquia'),
    ('Eslovenia'),
    ('España'), -- 60
    ('Estados Unidos'),
    ('Estonia'),
    ('Eswatini'),
    ('Etiopía'),
    ('Fiji'),
    ('Filipinas'),
    ('Finlandia'),
    ('Francia'),
    ('Gabón'),
    ('Gambia'), -- 70
    ('Georgia'),
    ('Ghana'),
    ('Granada'),
    ('Grecia'),
    ('Guatemala'),
    ('Guinea'),
    ('Guinea-Bisáu'),
    ('Guyana'),
    ('Haití'),
    ('Honduras'), -- 80
    ('Hungría'),
    ('India'),
    ('Indonesia'),
    ('Irak'),
    ('Irán'),
    ('Irlanda'),
    ('Islandia'),
    ('Islas Marshall'),
    ('Islas Salomón'),
    ('Islas Seychelles'), -- 90
    ('Israel'),
    ('Italia'),
    ('Jamaica'),
    ('Japón'),
    ('Jordania'),
    ('Kazajistán'),
    ('Kenia'),
    ('Kirguistán'),
    ('Kiribati'),
    ('Kuwait'), -- 100
    ('Laos'),
    ('Lesoto'),
    ('Letonia'),
    ('Líbano'),
    ('Liberia'),
    ('Libia'),
    ('Liechtenstein'),
    ('Lituania'),
    ('Luxemburgo'),
    ('Madagascar'), -- 110
    ('Malasia'),
    ('Malaui'),
    ('Maldivas'),
    ('Malí'),
    ('Malta'),
    ('Marruecos'),
    ('Mauricio'),
    ('Mauritania'),
    ('México'),
    ('Micronesia'), -- 120
    ('Moldavia'),
    ('Mónaco'),
    ('Mongolia'),
    ('Mozambique'),
    ('Namibia'),
    ('Nauru'),
    ('Nepal'),
    ('Nicaragua'),
    ('Níger'),
    ('Nigeria'), -- 130
    ('Noruega'),
    ('Nueva Zelanda'),
    ('Omán'),
    ('Países Bajos'),
    ('Pakistán'),
    ('Palaos'),
    ('Panamá'),
    ('Papúa Nueva Guinea'),
    ('Paraguay'),
    ('Perú'), -- 140
    ('Polonia'),
    ('Portugal'),
    ('Reino Unido'),
    ('República Checa'),
    ('República Dominicana'),
    ('Ruanda'),
    ('Rumania'),
    ('San Cristóbal y Nieves'),
    ('San Marino'),
    ('San Vicente y las Granadinas'), -- 150
    ('Santo Tomé y Príncipe'),
    ('Senegal'),
    ('Serbia'),
    ('Seychelles'),
    ('Sierra Leona'),
    ('Singapur'),
    ('Siria'),
    ('Somalia'),
    ('Sri Lanka'),
    ('Sudáfrica'), -- 160
    ('Sudán'),
    ('Sudán del Sur'),
    ('Suecia'),
    ('Suiza'),
    ('Surinam'),
    ('Tailandia'),
    ('Tanzania'),
    ('Tayikistán'),
    ('Timor Oriental'),
    ('Togo'), -- 170
    ('Tonga'),
    ('Trinidad y Tobago'),
    ('Túnez'),
    ('Turkmenistán'),
    ('Turquía'),
    ('Tuvalu'),
    ('Uganda'),
    ('Ucrania'),
    ('Uruguay'),
    ('Uzbekistán'), -- 180
    ('Vanuatu'),
    ('Vaticano'),
    ('Venezuela'),
    ('Vietnam'),
    ('Yemen'),
    ('Yibuti'),
    ('Zambia'),
    ('Zimbabue');

go
---------------
-- PROVINCES --
---------------
print '';

print 'Inserting initial data into provinces table...';

insert into
    provinces (name, country_id)
values
    ('Buenos Aires', 9),
    ('Catamarca', 9),
    ('Chaco', 9),
    ('Chubut', 9),
    ('CABA', 9),
    ('Córdoba', 9),
    ('Corrientes', 9),
    ('Entre Ríos', 9),
    ('Formosa', 9),
    ('Jujuy', 9), -- 10
    ('La Pampa', 9),
    ('La Rioja', 9),
    ('Mendoza', 9),
    ('Misiones', 9),
    ('Neuquén', 9),
    ('Río Negro', 9),
    ('Salta', 9),
    ('San Juan', 9),
    ('San Luis', 9),
    ('Santa Cruz', 9), -- 20
    ('Santa Fe', 9),
    ('Santiago del Estero', 9),
    ('Tierra del Fuego', 9),
    ('Tucumán', 9);

go
--------------------------
-- IDENTIFICATION TYPES --
--------------------------
print '';

print 'Inserting initial data into identification_types table...';

go
insert into
    identification_types (name, country_id)
values
    ('DNI', 9),
    ('CUIL/CUIT', 9),
    ('Otro', null);

go
-------------------
-- PRICING PLANS --
-------------------
print '';

print 'Inserting initial data into pricing_plans table...';

go
insert into
    pricing_plans (name, monthly_fee)
values
    ('Plan gratuito', 0),
    ('Plan profesional', 20),
    ('Plan empresarial', 30);

go
-----------
-- ROLES --
-----------
print '';

print 'Inserting initial data into roles table...';

go
insert into
    roles (name)
values
    ('Administrador'),
    ('Contabilidad'),
    ('Logística'),
    ('RRHH'),
    ('Ventas');

go