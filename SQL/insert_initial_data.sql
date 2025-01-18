use meeni_erp_db;

---------------
-- COUNTRIES --
---------------
go
insert into
    countries (country_name)
values
    ('Argentina');

---------------
-- PROVINCES --
---------------
insert into
    provinces (province_name, country_id)
values
    ('Buenos Aires', 1),
    ('Catamarca', 1),
    ('Chaco', 1),
    ('Chubut', 1),
    ('CABA', 1),
    ('Córdoba', 1),
    ('Corrientes', 1),
    ('Entre Ríos', 1),
    ('Formosa', 1),
    ('Jujuy', 1),
    ('La Pampa', 1),
    ('La Rioja', 1),
    ('Mendoza', 1),
    ('Misiones', 1),
    ('Neuquén', 1),
    ('Río Negro', 1),
    ('Salta', 1),
    ('San Juan', 1),
    ('San Luis', 1),
    ('Santa Cruz', 1),
    ('Santa Fe', 1),
    ('Santiago del Estero', 1),
    ('Tierra del Fuego', 1),
    ('Tucumán', 1);

-------------------
-- PRICING PLANS --
-------------------
go
insert into
    pricing_plans (pricing_plan_name, monthly_fee)
values
    ('Plan gratuito', 0),
    ('Plan profesional', 20),
    ('Plan empresarial', 30);

-----------
-- ROLES --
-----------
go
insert into
    roles (role_name)
values
    ('Dueño'),
    ('Contabilidad'),
    ('Logística'),
    ('RRHH'),
    ('Ventas');

go