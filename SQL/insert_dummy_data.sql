use meeni_erp_db;

go
insert into
    images (image_url)
values
    ('https://i.imgur.com/jOSLaMH.png');

go
insert into
    organizations (organization_name, logo_image_id, pricing_plan_id)
values
    ('Berlinguieri Construcciones', 1, 2);

go
insert into
    users (username, user_password)
values
    ('admin', 'admin');

go
insert into
    user_role_rel (user_id, role_id)
values
    (1, 1);

go