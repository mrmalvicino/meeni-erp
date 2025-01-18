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
    ('https://i.imgur.com/vbTmUHj.png');

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
        cuit,
        legal_entity_name,
        email,
        phone,
        logo_image_id,
        address_id
    )
values
    (
        '20123456789',
        'Berlinguieri Co.',
        'contacto@berlinguieri.com',
        '1158873478',
        1,
        1
    ),
    (
        null,
        'Future Archi',
        'contacto@futurearchi.com',
        '1112345678',
        2,
        2
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
        '23456789015',
        'Industria Gamma',
        'ventas@industriagamma.com',
        null,
        null,
        3
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
    );

----------------------------
-- INTERNAL ORGANIZATIONS --
----------------------------
go
insert into
    internal_organizations (
        internal_organization_id,
        activity_status,
        admission_date,
        pricing_plan_id
    )
values
    (1, 1, '2024-10-10', 1),
    (2, 1, '2024-11-11', 2),
    (3, 1, '2024-12-12', 3);

----------------------------
-- EXTERNAL ORGANIZATIONS --
----------------------------
go
insert into
    external_organizations (external_organization_id)
values
    (4),
    (5),
    (6),
    (7),
    (8),
    (9),
    (10);

------------
-- PEOPLE --
------------
insert into
    people (
        cuil,
        first_name,
        last_name,
        email,
        phone,
        birth_date,
        profile_image_id,
        address_id,
        internal_organization_id
    )
values
    (
        '22345678',
        'Juan',
        'Pérez',
        'juan.perez@email.com',
        '1182345678',
        '1985-07-15',
        4,
        5,
        1
    ),
    (
        null,
        'María',
        'González',
        'maria.gonzalez@email.com',
        null,
        '1990-03-22',
        null,
        6
    ),
    (
        '28765432',
        'Pedro',
        'Martínez',
        'pedro.martinez@email.com',
        '1198765432',
        '1987-12-30',
        null,
        null
    ),
    (
        null,
        'Laura',
        'Rodríguez',
        'laura.rodriguez@email.com',
        '1155667788',
        null,
        null,
        null
    ),
    (
        '31223344',
        'Carlos',
        'Fernández',
        'carlos.fernandez@email.com',
        null,
        '1982-05-01',
        null,
        null
    ),
    (
        '22334455',
        'Ana',
        'López',
        'ana.lopez@email.com',
        '1177889900',
        '1995-09-10',
        null,
        7
    ),
    (
        null,
        'José',
        'Sánchez',
        'jose.sanchez@email.com',
        '1112349876',
        '1980-01-14',
        null,
        null
    ),
    (
        '33445566',
        'Lucía',
        'Paredes',
        'lucia.paredes@email.com',
        '1199887766',
        '1992-11-20',
        null,
        null
    ),
    (
        null,
        'Ricardo',
        'Díaz',
        'ricardo.diaz@email.com',
        null,
        '1993-04-18',
        null,
        null
    ),
    (
        '14556677',
        'Patricia',
        'Vargas',
        'patricia.vargas@email.com',
        '1166554433',
        null,
        null,
        null
    ),
    (
        '15667788',
        'Francisco',
        'Gómez',
        'francisco.gomez@email.com',
        '1188776655',
        '1989-08-29',
        null,
        null
    ),
    (
        null,
        'Julieta',
        'Morales',
        'julieta.morales@email.com',
        '1166553322',
        null,
        null,
        null
    ),
    (
        '26778899',
        'Alberto',
        'Jiménez',
        'alberto.jimenez@email.com',
        null,
        '1988-06-12',
        null,
        null
    ),
    (
        null,
        'Roberto',
        'Ramírez',
        'roberto.ramirez@email.com',
        null,
        null,
        null,
        null
    ),
    (
        '17889900',
        'Isabel',
        'Torres',
        'isabel.torres@email.com',
        '1199887766',
        '1991-02-25',
        null,
        null
    ),
    (
        null,
        'Santiago',
        'Ruiz',
        'santiago.ruiz@email.com',
        '1111223344',
        '1994-07-05',
        null,
        null
    ),
    (
        '18990011',
        'Mercedes',
        'Méndez',
        'mercedes.mendez@email.com',
        '1122334455',
        null,
        null,
        null
    ),
    (
        null,
        'Gabriel',
        'Álvarez',
        'gabriel.alvarez@email.com',
        '1133445566',
        '1986-09-02',
        null,
        null
    ),
    (
        null,
        'Valentina',
        'Ríos',
        'valentina.rios@email.com',
        '1144556677',
        '1996-01-08',
        null,
        null
    ),
    (
        null,
        'Maximiliano',
        'Álvarez',
        'maxi_al@email.com',
        '1144556677',
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
        activity_status,
        external_organization_id,
        person_id,
        internal_organization_id
    )
values
    (1, 4, null, 1),
    (1, 5, null, 1),
    (1, 6, null, 2),
    (1, 7, null, 2),
    (1, 8, null, 3),
    (1, 9, null, 3),
    (1, 10, null, 1),
    (1, null, 4, 1),
    (1, null, 5, 1),
    (1, null, 6, 1),
    (1, null, 7, 1),
    (1, null, 8, 2),
    (1, null, 9, 2),
    (1, null, 10, 2),
    (1, null, 11, 2),
    (1, null, 12, 3),
    (1, null, 13, 3),
    (1, null, 14, 3),
    (1, null, 15, 3),
    (1, null, 16, 1),
    (1, null, 17, 1),
    (1, null, 18, 1),
    (1, null, 19, 1),
    (1, null, 20, 1);

---------------------------------------
-- BUSINESS PARTNERS X PARTNER TYPES --
---------------------------------------
go
insert into
    partner_type_rel (business_partner_id, partner_type_id)
values
    (1, 1),
    (1, 2),
    (2, 1),
    (2, 2),
    (3, 1),
    (3, 2),
    (4, 1),
    (4, 2),
    (5, 1),
    (6, 1),
    (7, 1),
    (8, 1),
    (9, 1),
    (10, 1),
    (11, 2),
    (12, 1),
    (13, 2),
    (14, 1),
    (15, 2),
    (16, 1),
    (17, 2),
    (18, 1),
    (19, 2),
    (20, 1),
    (21, 2),
    (22, 1),
    (23, 2),
    (24, 1);

---------------
-- EMPLOYEES --
---------------
go
insert into
    employees (employee_id, activity_status, admission_date)
values
    (1, 1, '2024-10-10'),
    (2, 1, '2024-10-11'),
    (3, 1, '2024-10-12'),
    (4, 1, '2024-10-13'),
    (5, 1, '2024-10-14'),
    (6, 1, '2024-10-15'),
    (7, 1, '2024-10-16'),
    (8, 1, '2024-10-17'),
    (9, 1, '2024-10-18'),
    (10, 1, '2024-10-19'),
    (11, 1, '2024-10-20'),
    (12, 1, '2024-10-21'),
    (13, 1, '2024-10-22'),
    (14, 1, '2024-10-23'),
    (15, 1, '2024-10-24'),
    (16, 1, '2024-10-25'),
    (17, 1, '2024-10-26'),
    (18, 1, '2024-10-27'),
    (19, 1, '2024-10-28'),
    (20, 1, '2024-10-29');

-----------
-- USERS --
-----------
go
insert into
    users (user_id, activity_status, username, password)
values
    (1, 1, 'admin', 'admin'),
    (2, 1, 'admin2', 'admin2'),
    (3, 1, 'admin3', 'admin3');

-------------------
-- USERS X ROLES --
-------------------
go
insert into
    user_role_rel (user_id, role_id)
values
    (1, 1),
    (2, 1),
    (3, 1);