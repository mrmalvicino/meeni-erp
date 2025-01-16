use meeni_erp_db;

go
insert into
    pricing_plans (pricing_plan_name, monthly_fee)
values
    ('Plan gratuito', 0),
    ('Plan profesional', 20),
    ('Plan empresarial', 30);

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