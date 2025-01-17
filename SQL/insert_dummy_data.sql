use meeni_erp_db;

------------
-- IMAGES --
------------
go
insert into
    images (image_url)
values
    ('https://i.imgur.com/jOSLaMH.png'),
    ('https://i.imgur.com/NcONOVV.png'),
    ('https://i.imgur.com/vbTmUHj.png'),
    (
        'https://img.freepik.com/foto-gratis/hombre-feliz-pie-playa_107420-9868.jpg'
    );

------------
-- CITIES --
------------
go
insert into
    cities (city_name, zip_code, province_id)
values
    ('Palermo', '1414', 5),
    ('Recoleta', '1023', 5),
    ('Don Torcuato', '1611', 1),
    ('La Plata', '1900', 1),
    ('Tigre', '1648', 1),
    ('Merlo', '5700', 19),
    ('Carlos Paz', '5152', 6);

---------------
-- ADDRESSES --
---------------
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
    ('Av. Falsa', '1234', '4C', null, 2),
    ('Calle Sin Salida', '200', null, null, 3),
    ('Calle De Valuada', '2975', null, null, 4),
    ('Av. del Río', '158', null, null, 5),
    ('Piedras Blancas', '789', null, null, 6),
    ('Copinita', '450', null, 'Puerta verde', 7);

--------------------
-- LEGAL ENTITIES --
--------------------
go
insert into
    legal_entities (
        legal_entity_name,
        cuit,
        email,
        phone,
        logo_image_id,
        address_id
    )
values
    (
        'Berlinguieri Co.',
        '20123456789',
        'contacto@berlinguieri.com',
        '1158873478',
        1,
        1
    ),
    (
        'Future Archi',
        null,
        'contacto@futurearchi.com',
        '1112345678',
        2,
        2
    ),
    (
        'Industria Gamma',
        '23456789015',
        'ventas@industriagamma.com',
        null,
        null,
        3
    ),
    (
        'El Buen Color',
        '27987654321',
        'info@elbuencolor.com',
        null,
        3,
        null
    ),
    (
        'Soluciones Omega',
        null,
        'soporte@solucionesomega.com',
        null,
        null,
        null
    ),
    (
        'Innovación Zeta',
        '23998877663',
        'contacto@innovacionzeta.com',
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
        null
    ),
    (
        'Consultora Épsilon',
        null,
        'consultas@consultoraepsilon.com',
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
        null
    ),
    (
        'Logística Lambda',
        '23556677889',
        'logistica@logisticalambda.com',
        null,
        null,
        null
    ),
    (
        'Marketing Mu',
        null,
        'marketing@marketingmu.com',
        '1199881122',
        null,
        null
    );

-------------------
-- ORGANIZATIONS --
-------------------
go
insert into
    organizations (organization_id, admission_date, pricing_plan_id)
values
    (1, '2024-10-10', 1),
    (2, '2024-11-11', 2),
    (4, '2024-12-12', 3);

------------
-- PEOPLE --
------------
insert into
    people (
        activity_status,
        first_name,
        last_name,
        dni,
        email,
        phone,
        birth_date,
        profile_image_id,
        address_id
    )
values
    (
        true,
        'Juan',
        'Pérez',
        '12345678',
        'juan.perez@email.com',
        '011-12345678',
        '1985-07-15',
        4,
        5
    ),
    (
        true,
        'María',
        'González',
        null,
        'maria.gonzalez@email.com',
        null,
        '1990-03-22',
        null,
        6
    ),
    (
        true,
        'Pedro',
        'Martínez',
        '98765432',
        'pedro.martinez@email.com',
        '011-98765432',
        '1987-12-30',
        null,
        null
    ),
    (
        false,
        'Laura',
        'Rodríguez',
        null,
        'laura.rodriguez@email.com',
        '011-55667788',
        null,
        null,
        null
    ),
    (
        true,
        'Carlos',
        'Fernández',
        '11223344',
        'carlos.fernandez@email.com',
        null,
        '1982-05-01',
        null,
        null
    ),
    (
        true,
        'Ana',
        'López',
        '22334455',
        'ana.lopez@email.com',
        '011-77889900',
        '1995-09-10',
        null,
        7
    ),
    (
        false,
        'José',
        'Sánchez',
        null,
        'jose.sanchez@email.com',
        '011-12349876',
        '1980-01-14',
        null,
        null
    ),
    (
        true,
        'Lucía',
        'Paredes',
        '33445566',
        'lucia.paredes@email.com',
        '011-99887766',
        '1992-11-20',
        null,
        null
    ),
    (
        true,
        'Ricardo',
        'Díaz',
        null,
        'ricardo.diaz@email.com',
        null,
        '1993-04-18',
        null,
        null
    ),
    (
        false,
        'Patricia',
        'Vargas',
        '44556677',
        'patricia.vargas@email.com',
        '011-66554433',
        null,
        null,
        null
    ),
    (
        true,
        'Francisco',
        'Gómez',
        '55667788',
        'francisco.gomez@email.com',
        '011-88776655',
        '1989-08-29',
        null,
        null
    ),
    (
        true,
        'Julieta',
        'Morales',
        null,
        'julieta.morales@email.com',
        '011-66553322',
        null,
        null,
        null
    ),
    (
        true,
        'Alberto',
        'Jiménez',
        '66778899',
        'alberto.jimenez@email.com',
        null,
        '1988-06-12',
        null,
        null
    ),
    (
        false,
        'Roberto',
        'Ramírez',
        null,
        'roberto.ramirez@email.com',
        null,
        null,
        null,
        null
    ),
    (
        false,
        'Isabel',
        'Torres',
        '77889900',
        'isabel.torres@email.com',
        '011-99887766',
        '1991-02-25',
        null,
        null
    ),
    (
        true,
        'Santiago',
        'Ruiz',
        null,
        'santiago.ruiz@email.com',
        '011-11223344',
        '1994-07-05',
        null,
        null
    ),
    (
        true,
        'Mercedes',
        'Méndez',
        '88990011',
        'mercedes.mendez@email.com',
        '011-22334455',
        null,
        null,
        null
    ),
    (
        false,
        'Gabriel',
        'Alvarez',
        null,
        'gabriel.alvarez@email.com',
        '011-33445566',
        '1986-09-02',
        null,
        null
    ),
    (
        true,
        'Valentina',
        'Ríos',
        null,
        'valentina.rios@email.com',
        '011-44556677',
        '1996-01-08',
        null,
        null
    );

-----------------------
-- BUSINESS PARTNERS --
-----------------------

---------------------------------------
-- BUSINESS PARTNERS X PARTNER TYPES --
---------------------------------------

-----------
-- USERS --
-----------

go
insert into
    users (username, user_password, organization_id)
values
    ('admin', 'admin', 1);

-------------------
-- USERS X ROLES --
-------------------

go
insert into
    user_role_rel (user_id, role_id)
values
    (1, 1);

go

---------------
-- POSITIONS --
---------------

---------------
-- EMPLOYEES --
---------------