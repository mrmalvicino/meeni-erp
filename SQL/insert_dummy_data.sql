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
    ('https://i.imgur.com/vbTmUHj.png');

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
    ('Carlos Paz', '5152', 6);

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
    ('Av. del Río', '158', null, null, 5),
    ('Piedras Blancas', '789', null, null, 6),
    ('Copinita', '450', null, 'Puerta verde', 7);

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
        tax_code,
        email,
        phone,
        birth_date,
        image_id,
        address_id
    )
values
    (
        'Berlinguieri Co.',
        '20-12345678-9',
        'contacto@berlinguieri.com',
        '1158873478',
        '1990-12-12',
        1,
        1
    ),
    (
        'Future Archi',
        null,
        'contacto@futurearchi.com',
        '1112345678',
        null,
        2,
        2
    ),
    (
        'El Buen Color',
        '27-98765432-1',
        'info@elbuencolor.com',
        null,
        null,
        3,
        null
    ),
    (
        'Industria Gamma',
        '23-45678901-5',
        'ventas@industriagamma.com',
        null,
        null,
        null,
        3
    ),
    (
        'Soluciones Omega',
        null,
        'soporte@solucionesomega.com',
        null,
        null,
        null,
        null
    ),
    (
        'Innovación Zeta',
        '23-99887766-3',
        'contacto@innovacionzeta.com',
        null,
        null,
        null,
        4
    ),
    (
        'Corporación Delta',
        null,
        'info@corporaciondelta.com',
        '1177889900',
        null,
        null,
        null
    ),
    (
        'Consultora Épsilon',
        null,
        'consultas@consultoraepsilon.com',
        null,
        null,
        null,
        null
    ),
    (
        'Tecnología Kappa',
        null,
        'contacto@tecnologiakappa.com',
        null,
        null,
        null,
        null
    ),
    (
        'Logística Lambda',
        '23-55667788-9',
        'logistica@logisticalambda.com',
        null,
        null,
        null,
        null
    ),
    (
        'Pérez, Juán',
        '20-22345678-9',
        'juan.perez@email.com',
        '1182345678',
        '1985-07-15',
        null,
        5
    ),
    (
        'González, María',
        null,
        'maria.gonzalez@email.com',
        null,
        '1990-03-22',
        null,
        6
    ),
    (
        'Martínez, Pedro',
        '20-28765432-9',
        'pedro.martinez@email.com',
        '1198765432',
        '1987-12-30',
        null,
        null
    ),
    (
        'Rodríguez, Laura',
        null,
        'laura.rodriguez@email.com',
        '1155667788',
        null,
        null,
        null
    ),
    (
        'Fernández, Carlos',
        '23-31223344-0',
        'carlos.fernandez@email.com',
        null,
        '1982-05-01',
        null,
        null
    ),
    (
        'López, Ana',
        '20-22334455-7',
        'ana.lopez@email.com',
        '1177889900',
        '1995-09-10',
        null,
        7
    ),
    (
        'Sánchez, José',
        null,
        'jose.sanchez@email.com',
        '1112349876',
        '1980-01-14',
        null,
        null
    ),
    (
        'Paredes, Lucía',
        '33445566',
        'lucia.paredes@email.com',
        '1199887766',
        '1992-11-20',
        null,
        null
    ),
    (
        'Díaz, Ricardo',
        null,
        'ricardo.diaz@email.com',
        null,
        '1993-04-18',
        null,
        null
    ),
    (
        'Vargas, Patricia',
        '14556677',
        'patricia.vargas@email.com',
        '1166554433',
        null,
        null,
        null
    ),
    (
        'Gómez, Francisco',
        '15667788',
        'francisco.gomez@email.com',
        '1188776655',
        '1989-08-29',
        null,
        null
    ),
    (
        'Morales, Julieta',
        null,
        'julieta.morales@email.com',
        '1166553322',
        null,
        null,
        null
    ),
    (
        'Jiménez, Alberto',
        '26778899',
        'alberto.jimenez@email.com',
        null,
        '1988-06-12',
        null,
        null
    ),
    (
        'Ramírez, Roberto',
        null,
        'roberto.ramirez@email.com',
        null,
        null,
        null,
        null
    ),
    (
        'Torres, Isabel',
        '17889900',
        'isabel.torres@email.com',
        '1199887766',
        '1991-02-25',
        null,
        null
    ),
    (
        'Ruiz, Santiago',
        null,
        'santiago.ruiz@email.com',
        '1111223344',
        '1994-07-05',
        null,
        null
    ),
    (
        'Méndez, Mercedes',
        '18990011',
        'mercedes.mendez@email.com',
        '1122334455',
        null,
        null,
        null
    ),
    (
        'Álvarez, Gabriel',
        null,
        'gabriel.alvarez@email.com',
        '1133445566',
        '1986-09-02',
        null,
        null
    ),
    (
        'Ríos, Valentina',
        null,
        'valentina.rios@email.com',
        '1144556677',
        '1996-01-08',
        null,
        null
    ),
    (
        'Álvarez, Maximiliano',
        null,
        'maxi_al@email.com',
        '1144556677',
        '1996-01-08',
        null,
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