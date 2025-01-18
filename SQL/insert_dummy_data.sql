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

-------------------
-- ORGANIZATIONS --
-------------------
go
insert into
    organizations (activity_status, admission_date, pricing_plan_id)
values
    (true, '2024-10-10', 1),
    (true, '2024-11-11', 2),
    (false, '2024-12-12', 3);

--------------------
-- LEGAL ENTITIES --
--------------------
go
insert into
    legal_entities (
        cuit,
        legal_entity_name,
        email,
        phone,
        logo_image_id,
        address_id,
        organization_id
    )
values
    (
        '20123456789',
        'Berlinguieri Co.',
        'contacto@berlinguieri.com',
        '1158873478',
        1,
        1,
        1
    ),
    (
        null,
        'Future Archi',
        'contacto@futurearchi.com',
        '1112345678',
        2,
        2,
        int;problema
    ),
    (
        '23456789015',
        'Industria Gamma',
        'ventas@industriagamma.com',
        null,
        null,
        3
    ),
    (
        '27987654321',
        'El Buen Color',
        'info@elbuencolor.com',
        null,
        3,
        null
    ),
    (
        null,
        'Soluciones Omega',
        'soporte@solucionesomega.com',
        null,
        null,
        null
    ),
    (
        '23998877663',
        'Innovación Zeta',
        'contacto@innovacionzeta.com',
        null,
        null,
        4
    ),
    (
        null,
        'Corporación Delta',
        'info@corporaciondelta.com',
        '1177889900',
        null,
        null
    ),
    (
        null,
        'Consultora Épsilon',
        'consultas@consultoraepsilon.com',
        null,
        null,
        null
    ),
    (
        null,
        'Tecnología Kappa',
        'contacto@tecnologiakappa.com',
        null,
        null,
        null
    ),
    (
        '23556677889',
        'Logística Lambda',
        'logistica@logisticalambda.com',
        null,
        null,
        null
    ),
    (
        null,
        'Marketing Mu',
        'marketing@marketingmu.com',
        '1199881122',
        null,
        null
    );

------------
-- PEOPLE --
------------
insert into
    people (
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
go
insert into
    business_partners (
        organization_id,
        activity_status,
        legal_entity_id,
        person_id
    )
values
    (1, true, 2, null),
    (1, true, 4, null);

---------------------------------------
-- BUSINESS PARTNERS X PARTNER TYPES --
---------------------------------------
go
insert into
    partner_type_rel (
        organization_id,
        business_partner_id,
        partner_type_id
    )
values
    (1, 1, 1),
    (1, 1, 2),
    (1, 2, 2);

---------------
-- EMPLOYEES --
---------------
go
insert into
    employees (
        organization_id,
        employee_id,
        activity_status,
        admission_date,
        user_id
    )
values
    (1, 6, true, '2024-10-10', 1),
    (1, 7, true, '2024-10-10', null),
    (1, 8, true, '2024-10-10', null),
    (2, 9, true, '2024-11-11', 2);

-----------
-- USERS --
-----------
go
insert into
    users (activity_status, username, user_password)
values
    (true, 'admin', 'admin'),
    (true, 'owner', 'owner');

-------------------
-- USERS X ROLES --
-------------------
go
insert into
    user_role_rel (user_id, role_id)
values
    (1, 1),
    (2, 1);