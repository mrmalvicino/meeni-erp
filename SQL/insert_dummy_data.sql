use meeni_erp_db;

go
------------
-- IMAGES --
------------
print '';

print 'Inserting dummy data into images table...';

go
insert into
    images (url)
values
    ('https://i.imgur.com/jOSLaMH.png'),
    ('https://i.imgur.com/NcONOVV.png'),
    ('https://i.imgur.com/vbTmUHj.png'),
    ('https://i.imgur.com/zeJG0nu.jpeg'),
    ('https://i.imgur.com/TX8pw5i.jpeg'),
    ('https://i.imgur.com/i5w8evO.png'),
    ('https://i.imgur.com/p4phZOf.png'),
    ('https://i.imgur.com/ggVhuvi.png'),
    ('https://i.imgur.com/JFYBh8h.jpeg'),
    ('https://i.imgur.com/O9f6CrE.jpeg');

go
------------
-- CITIES --
------------
print '';

print 'Inserting dummy data into cities table...';

go
insert into
    cities (name, zip_code, province_id)
values
    ('Palermo', '1414', 5),
    ('Recoleta', '1023', 5),
    ('Don Torcuato', '1611', 1),
    ('La Plata', '1900', 1),
    ('Tigre', '1648', 1),
    ('Merlo', '5700', 19),
    ('Carlos Paz', '5152', 6),
    ('Villa Adelina', null, 1);

go
---------------
-- ADDRESSES --
---------------
print '';

print 'Inserting dummy data into addresses table...';

insert into
    addresses (
        street_name,
        street_number,
        flat,
        details,
        city_id
    )
values
    ('Av. Inventada', '3500', '9B', 'Sin timbre', 1),
    ('Av. Inventada', '3500', '2C', null, 1),
    ('Calle Ficticia', '1200', '1D', null, 1),
    ('Av. Falsa', '5600', '4C', null, 2),
    ('Av. Falsa', '1234', '4C', 'Cerca del cruce', 2),
    ('Calle Sin Salida', '200', null, null, 3),
    ('Calle De Valuada', '2975', null, null, 4),
    ('Av. del Río', '158', '2C', 'Puerta roja', 5),
    ('Piedras Blancas', '789', null, null, 6),
    ('Copinita', '450', null, 'Puerta verde', 7),
    ('Piedra Mala', '546', null, null, 8);

go
---------------------
-- IDENTIFICATIONS --
---------------------
print '';

print 'Inserting dummy data into identifications table...';

insert into
    identifications (code, identification_type_id)
values
    ('20-12345678-9', '2'),
    ('20-12345678-9', '2'),
    ('23-45678901-5', '2'),
    ('23-99887766-3', '2'),
    ('23-55667788-9', '2'),
    ('20-22345678-9', '2'),
    ('20-28765432-9', '2'),
    ('23-31223344-0', '2'),
    ('20-22334455-7', '2'),
    ('33445566', '1'), -- 10
    ('14556677', '1'),
    ('15667788', '1'),
    ('26778899', '1'),
    ('17889900', '1'),
    ('18990011', '1');

go
--------------
-- ENTITIES --
--------------
print '';

print 'Inserting dummy data into entities table...';

go
insert into
    entities (
        name,
        is_organization,
        email,
        phone,
        birth_date,
        image_id,
        address_id,
        identification_id
    )
values
    (
        'Berlinguieri Co.',
        1,
        'contacto@berlinguieri.com',
        '1158873478',
        '1990-12-12',
        1,
        1,
        1
    ),
    (
        'Future Archi',
        1,
        'contacto@futurearchi.com',
        '1112345678',
        null,
        2,
        2,
        null
    ),
    (
        'El Buen Color',
        1,
        'info@elbuencolor.com',
        null,
        null,
        3,
        null,
        2
    ),
    (
        'Industria Gamma',
        1,
        'ventas@industriagamma.com',
        null,
        null,
        null,
        3,
        3
    ),
    (
        'Soluciones Omega',
        1,
        'soporte@solucionesomega.com',
        null,
        null,
        null,
        null,
        null
    ),
    (
        'Innovación Zeta',
        1,
        'contacto@innovacionzeta.com',
        null,
        null,
        null,
        4,
        4
    ),
    (
        'Corporación Delta',
        1,
        'info@corporaciondelta.com',
        '1177889900',
        null,
        null,
        null,
        null
    ),
    (
        'Consultora Épsilon',
        1,
        'consultas@consultoraepsilon.com',
        null,
        null,
        null,
        null,
        null
    ),
    (
        'Tecnología Kappa',
        1,
        'contacto@tecnologiakappa.com',
        null,
        null,
        null,
        null,
        null
    ),
    (
        'Logística Lambda',
        1,
        'logistica@logisticalambda.com',
        null,
        null,
        null,
        null,
        5
    ), -- 10
    (
        'Pérez, Juán',
        0,
        'juan.perez@email.com',
        '1182345678',
        '1985-07-15',
        null,
        5,
        6
    ),
    (
        'González, María',
        0,
        'maria.gonzalez@email.com',
        null,
        '1990-03-22',
        null,
        6,
        null
    ),
    (
        'Martínez, Pedro',
        0,
        'pedro.martinez@email.com',
        '1198765432',
        '1987-12-30',
        null,
        null,
        7
    ),
    (
        'Rodríguez, Laura',
        0,
        'laura.rodriguez@email.com',
        '1155667788',
        null,
        null,
        null,
        null
    ),
    (
        'Fernández, Carlos',
        0,
        'carlos.fernandez@email.com',
        null,
        '1982-05-01',
        null,
        null,
        8
    ),
    (
        'López, Ana',
        0,
        'ana.lopez@email.com',
        '1177889900',
        '1995-09-10',
        null,
        7,
        9
    ),
    (
        'Sánchez, José',
        0,
        'jose.sanchez@email.com',
        '1112349876',
        '1980-01-14',
        null,
        null,
        null
    ),
    (
        'Paredes, Lucía',
        0,
        'lucia.paredes@email.com',
        '1199887766',
        '1992-11-20',
        null,
        null,
        10
    ),
    (
        'Díaz, Ricardo',
        0,
        'ricardo.diaz@email.com',
        null,
        '1993-04-18',
        null,
        null,
        null
    ),
    (
        'Vargas, Patricia',
        0,
        'patricia.vargas@email.com',
        '1166554433',
        null,
        null,
        null,
        11
    ), -- 20
    (
        'Gómez, Francisco',
        0,
        'francisco.gomez@email.com',
        '1188776655',
        '1989-08-29',
        4,
        8,
        12
    ),
    (
        'Morales, Julieta',
        0,
        'julieta.morales@email.com',
        '1166553322',
        null,
        null,
        null,
        null
    ),
    (
        'Jiménez, Alberto',
        0,
        'alberto.jimenez@email.com',
        null,
        '1988-06-12',
        null,
        null,
        13
    ),
    (
        'Ramírez, Roberto',
        0,
        'roberto.ramirez@email.com',
        null,
        null,
        null,
        null,
        null
    ),
    (
        'Torres, Isabel',
        0,
        'isabel.torres@email.com',
        '1199887766',
        '1991-02-25',
        5,
        9,
        14
    ),
    (
        'Ruiz, Santiago',
        0,
        'santiago.ruiz@email.com',
        '1111223344',
        '1994-07-05',
        null,
        null,
        null
    ),
    (
        'Méndez, Mercedes',
        0,
        'mercedes.mendez@email.com',
        '1122334455',
        null,
        null,
        null,
        15
    ),
    (
        'Álvarez, Gabriel',
        0,
        'gabriel.alvarez@email.com',
        '1133445566',
        '1986-09-02',
        null,
        null,
        null
    ),
    (
        'Ríos, Valentina',
        0,
        'valentina.rios@email.com',
        '1144556677',
        '1996-01-08',
        null,
        null,
        null
    ),
    (
        'Álvarez, Maximiliano',
        0,
        'maxi_al@email.com',
        '1144556677',
        '1996-01-08',
        null,
        10,
        null
    );

go
-------------------
-- ORGANIZATIONS --
-------------------
print '';

print 'Inserting dummy data into organizations table...';

go
insert into
    organizations (
        organization_id,
        activity_status,
        admission_date,
        pricing_plan_id
    )
values
    (1, 1, '2024-10-10', 1),
    (2, 1, '2024-11-11', 1),
    (3, 0, '2024-12-12', 3);

go
------------------
-- STAKEHOLDERS --
------------------
print '';

print 'Inserting dummy data into stakeholders table...';

go
insert into
    stakeholders (stakeholder_id, organization_id)
values
    (4, 1),
    (5, 1),
    (6, 1),
    (7, 2),
    (8, 2),
    (9, 2),
    (10, 3),
    (11, 1),
    (12, 1),
    (13, 1),
    (14, 1),
    (15, 1),
    (16, 2),
    (17, 2),
    (18, 2),
    (19, 3),
    (20, 3),
    (21, 1),
    (22, 1),
    (23, 1),
    (24, 1),
    (25, 2),
    (26, 2),
    (27, 2),
    (28, 3),
    (29, 3),
    (30, 3);

go
--------------
-- PARTNERS --
--------------
print '';

print 'Inserting dummy data into partners table...';

go
insert into
    partners (
        partner_id,
        activity_status,
        is_client,
        is_supplier
    )
values
    (4, 1, 1, 1),
    (5, 1, 1, 1),
    (6, 0, 1, 0),
    (7, 1, 1, 1),
    (8, 1, 1, 1),
    (9, 0, 0, 0),
    (10, 1, 1, 1),
    (11, 1, 0, 1),
    (12, 0, 1, 0),
    (13, 1, 0, 1),
    (14, 1, 1, 0),
    (15, 0, 0, 1),
    (16, 1, 1, 0),
    (17, 1, 0, 1),
    (18, 0, 1, 0),
    (19, 1, 0, 1),
    (20, 1, 0, 1);

go
---------------
-- EMPLOYEES --
---------------
print '';

print 'Inserting dummy data into employees table...';

go
insert into
    employees (employee_id, activity_status, admission_date)
values
    (21, 1, '2024-10-10'),
    (22, 1, '2024-10-11'),
    (23, 0, '2024-10-12'),
    (24, 1, '2024-10-22'),
    (25, 1, '2024-10-23'),
    (26, 0, '2024-10-24'),
    (27, 1, '2024-11-25'),
    (28, 1, '2024-11-26'),
    (29, 0, '2024-11-27'),
    (30, 1, '2024-12-28');

go
-----------
-- USERS --
-----------
print '';

print 'Inserting dummy data into users table...';

go
insert into
    users (user_id, username, password)
values
    (21, 'admin', 'admin'),
    (25, 'admin2', 'admin2'),
    (28, 'admin3', 'admin3');

go
-------------------------
-- USER-ROLE RELATIONS --
-------------------------
print '';

print 'Inserting dummy data into user_role_rel table...';

go
insert into
    user_role_rel (user_id, role_id)
values
    (21, 1),
    (25, 1),
    (28, 1);

go
------------
-- BRANDS --
------------
print '';

print 'Inserting dummy data into brands table...';

go
insert into
    brands (name)
values
    ('Boden Design'),
    ('Harte Flooring'),
    ('Fastix');

go
--------------
-- PRODUCTS --
--------------
print '';

print 'Inserting dummy data into products table...';

go
insert into
    products (
        activity_status,
        is_service,
        name,
        description,
        sku,
        price,
        cost,
        brand_id
    )
values
    (
        1,
        0,
        'Zócalo Prepintado Blanco',
        'Ancho: 7,5 cm. Largo: 2 m. Material: MDF.',
        null,
        4200,
        2000,
        1
    ),
    (
        1,
        0,
        'Piso Roble Oscuro SCP',
        'Grosor: 5mm. Caja de 10 u',
        null,
        35000,
        20000,
        2
    ),
    (
        1,
        0,
        'Sellador Transparente',
        'Contenido: 25g',
        null,
        5000,
        4000,
        3
    ),
    (
        1,
        1,
        'Flete a CABA',
        null,
        null,
        90000,
        70000,
        null
    ),
    (
        1,
        1,
        'Flete a ZN',
        null,
        null,
        70000,
        50000,
        null
    );

go
----------------
-- CATEGORIES --
----------------
print '';

print 'Inserting dummy data into categories table...';

go
insert into
    categories (name)
values
    ('Zócalo'),
    ('Piso vinílico'),
    ('Sellador'),
    ('Pegamento');

go
--------------------------------
-- PRODUCT-CATEGORY RELATIONS --
--------------------------------
print '';

print 'Inserting dummy data into product_category_rel table...';

go
insert into
    product_category_rel (product_id, category_id)
values
    (1, 1),
    (2, 2),
    (3, 3),
    (3, 4);

go
-----------------------------
-- PRODUCT-IMAGE RELATIONS --
-----------------------------
print '';

print 'Inserting dummy data into product_image_rel table...';

go
insert into
    product_image_rel (product_id, image_id)
values
    (1, 6),
    (1, 7),
    (2, 8),
    (2, 9),
    (3, 10);

go
----------------
-- WAREHOUSES --
----------------
print '';

print 'Inserting dummy data into warehouses table...';

go
insert into
    warehouses (activity_status, name, address_id)
values
    (1, 'Depósito', 11),
    (1, 'Showroom', null),
    (0, 'Local', null);

go
------------------
-- COMPARTMENTS --
------------------
print '';

print 'Inserting dummy data into compartments table...';

go
insert into
    compartments (
        activity_status,
        name,
        stock,
        product_id,
        warehouse_id
    )
values
    (1, 'Estantería A - Primer estante', 5, 1, 1),
    (1, 'Estantería A - Segundo estante', 10, 2, 1),
    (1, 'Estantería A - Tercer estante', 15, 3, 1),
    (1, 'Estantería B - Primer estante', 20, 1, 1),
    (1, 'Estantería B - Segundo estante', 30, 2, 1),
    (1, 'Pasillo', 50, 1, 1),
    (1, 'Esquina', 60, 2, 1);

go