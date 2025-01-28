use meeni_erp_db;

go
------------
-- IMAGES --
------------
-- (dummy data) --
print '';

print 'Creating images table...';

go
create table
    images (
        image_id int identity (1, 1) not null,
        url varchar(300) not null,
        constraint uq_image unique (url),
        primary key (image_id)
    );

go
---------------
-- COUNTRIES --
---------------
-- (initial data) --
print '';

print 'Creating countries table...';

go
create table
    countries (
        country_id int identity (1, 1) not null,
        name varchar(50) not null,
        constraint uq_country unique (name),
        primary key (country_id)
    );

go
---------------
-- PROVINCES --
---------------
-- (initial data) --
print '';

print 'Creating provinces table...';

go
create table
    provinces (
        province_id int identity (1, 1) not null,
        name varchar(50) not null,
        country_id int not null,
        constraint uq_province unique (name, country_id),
        primary key (province_id),
        foreign key (country_id) references countries (country_id)
    );

go
------------
-- CITIES --
------------
-- (dummy data) --
print '';

print 'Creating cities table...';

go
create table
    cities (
        city_id int identity (1, 1) not null,
        name varchar(50) not null,
        zip_code varchar(10) null,
        province_id int not null,
        constraint uq_city unique (name, province_id),
        primary key (city_id),
        foreign key (province_id) references provinces (province_id)
    );

go
---------------
-- ADDRESSES --
---------------
-- (dummy data) --
print '';

print 'Creating addresses table...';

go
create table
    addresses (
        address_id int identity (1, 1) not null,
        street_name varchar(50) not null,
        street_number varchar(10) not null,
        flat varchar(10) null,
        details varchar(300) null,
        city_id int not null,
        constraint uq_address unique (street_name, street_number, flat, city_id),
        primary key (address_id),
        foreign key (city_id) references cities (city_id)
    );

go
--------------
-- ENTITIES --
--------------
-- (dummy data) --
print '';

print 'Creating entities table...';

go
create table
    entities (
        entity_id int identity (1, 1) not null,
        name varchar(50) not null,
        tax_code varchar(11) null,
        email varchar(50) null,
        phone varchar(50) null,
        birth_date date null,
        image_id int null,
        address_id int null,
        primary key (entity_id),
        foreign key (image_id) references images (image_id),
        foreign key (address_id) references addresses (address_id)
    );

go
-------------------
-- PRICING PLANS --
-------------------
-- (initial data) --
print '';

print 'Creating pricing_plans table...';

go
create table
    pricing_plans (
        pricing_plan_id int identity (1, 1) not null,
        name varchar(50) not null,
        monthly_fee money not null,
        constraint uq_pricing_plan unique (name),
        constraint chk_plan_fee check (0 <= monthly_fee),
        primary key (pricing_plan_id)
    );

go
-------------------
-- ORGANIZATIONS --
-------------------
-- (dummy data) --
print '';

print 'Creating organizations table...';

go
create table
    organizations (
        organization_id int not null,
        activity_status bit default (1) not null,
        admission_date date default cast(getdate () as date) not null,
        pricing_plan_id int not null,
        primary key (organization_id),
        foreign key (pricing_plan_id) references pricing_plans (pricing_plan_id),
        foreign key (organization_id) references entities (entity_id)
    );

go
------------------
-- STAKEHOLDERS --
------------------
-- (dummy data) --
print '';

print 'Creating stakeholders table...';

go
create table
    stakeholders (
        stakeholder_id int not null,
        organization_id int not null,
        primary key (stakeholder_id),
        foreign key (stakeholder_id) references entities (entity_id),
        foreign key (organization_id) references organizations (organization_id)
    );

go
--------------
-- PARTNERS --
--------------
-- (dummy data) --
print '';

print 'Creating partners table...';

go
create table
    partners (
        partner_id int not null,
        activity_status bit default (1) not null,
        is_client bit not null,
        is_supplier bit not null,
        constraint chk_is_any check (
            is_client is not null
            or is_supplier is not null
        ),
        primary key (partner_id),
        foreign key (partner_id) references stakeholders (stakeholder_id)
    );

go
---------------
-- EMPLOYEES --
---------------
-- (dummy data) --
print '';

print 'Creating employees table...';

go
create table
    employees (
        employee_id int not null,
        activity_status bit default (1) not null,
        admission_date date default cast(getdate () as date) not null,
        primary key (employee_id),
        foreign key (employee_id) references stakeholders (stakeholder_id)
    );

go
-----------
-- ROLES --
-----------
-- (initial data) --
print '';

print 'Creating roles table...';

go
create table
    roles (
        role_id int identity (1, 1) not null,
        name varchar(20) not null,
        constraint uq_role unique (name),
        primary key (role_id)
    );

go
-----------
-- USERS --
-----------
-- (dummy data) --
print '';

print 'Creating users table...';

go
create table
    users (
        user_id int not null,
        username varchar(50) not null,
        password varchar(50) not null,
        constraint uq_user unique (username),
        primary key (user_id),
        foreign key (user_id) references employees (employee_id)
    );

go
-------------------------
-- USER-ROLE RELATIONS --
-------------------------
-- (dummy data) --
print '';

print 'Creating user_role_rel table...';

go
create table
    user_role_rel (
        user_id int not null,
        role_id int not null,
        primary key (user_id, role_id),
        foreign key (user_id) references users (user_id),
        foreign key (role_id) references roles (role_id)
    );

go