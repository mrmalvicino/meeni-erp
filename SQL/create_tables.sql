use meeni_erp_db;

go
create table
    images (
        image_id int identity (1, 1) not null,
        image_url varchar(500) not null,
        constraint uq_image unique (image_url),
        primary key (image_id)
    );

go
create table
    countries (
        country_id int identity (1, 1) not null,
        country_name varchar(50) not null,
        constraint uq_country unique (country_name),
        primary key (country_id)
    );

go
create table
    provinces (
        province_id int identity (1, 1) not null,
        province_name varchar(50) not null,
        country_id int not null,
        constraint uq_province unique (province_name, country_id),
        primary key (province_id),
        foreign key (country_id) references countries (country_id)
    );

go
create table
    cities (
        city_id int identity (1, 1) not null,
        city_name varchar(50) not null,
        zip_code varchar(50) null,
        province_id int not null,
        constraint uq_city unique (city_name, province_id),
        primary key (city_id),
        foreign key (province_id) references provinces (province_id)
    );

go
create table
    addresses (
        address_id int identity (1, 1) not null,
        street_name varchar(50) not null,
        street_number varchar(10) not null,
        flat varchar(50) null,
        details varchar(500) null,
        city_id int not null,
        constraint uq_adress unique (street_name, street_number, flat, city_id),
        primary key (address_id),
        foreign key (city_id) references cities (city_id)
    );

go
create table
    legal_entities (
        legal_entity_id int identity (1, 1) not null,
        activity_status bit default (1) not null,
        legal_entity_name varchar(50) not null,
        cuit varchar(50) null,
        email varchar(50) not null,
        phone varchar(50) null,
        logo_image_id int null,
        address_id int null,
        constraint uq_entity_cuit unique (cuit),
        constraint uq_entity_email unique (email),
        primary key (legal_entity_id),
        foreign key (address_id) references addresses (address_id),
        foreign key (logo_image_id) references images (image_id)
    );

go
create table
    pricing_plans (
        pricing_plan_id int identity (1, 1) not null,
        pricing_plan_name varchar(50) not null,
        monthly_fee money not null,
        constraint uq_pricing_plan unique (pricing_plan_name),
        constraint chk_plan_fee check (0 <= monthly_fee),
        primary key (pricing_plan_id)
    );

go
create table
    organizations (
        organization_id int not null,
        admission_date date default cast(getdate () as date) not null,
        pricing_plan_id int not null,
        primary key (organization_id),
        foreign key (organization_id) references legal_entities (legal_entity_id),
        foreign key (pricing_plan_id) references pricing_plans (pricing_plan_id)
    );

go
create table
    partner_types (
        partner_type_id int identity (1, 1) not null,
        partner_type_name varchar(50) not null,
        constraint uq_partner_type unique (partner_type_name),
        primary key (partner_type_id)
    );

go
create table
    business_partners (
        organization_id int not null,
        business_partner_id int identity (1, 1) not null,
        activity_status bit default (1) not null,
        legal_entity_id int null,
        constraint chk_auto_reference check (organization_id != legal_entity_id),
        primary key (organization_id, business_partner_id),
        foreign key (organization_id) references organizations (organization_id),
        foreign key (legal_entity_id) references legal_entities (legal_entity_id)
    );

go
create table
    partner_type_rel (
        organization_id int not null,
        business_partner_id int not null,
        partner_type_id int not null,
        primary key (
            organization_id,
            business_partner_id,
            partner_type_id
        ),
        foreign key (organization_id) references business_partners (organization_id),
        foreign key (business_partner_id) references business_partners (business_partner_id),
        foreign key (partner_type_id) references business_partner_types (partner_type_id)
    );

go
create table
    people (
        person_id int identity (1, 1) not null,
        activity_status bit default (1) not null,
        first_name varchar(50) not null,
        last_name varchar(50) not null,
        dni varchar(50) null,
        email varchar(50) not null,
        phone varchar(50) null,
        birth_date date null,
        profile_image_id int null,
        address_id int null,
        business_partner_id int null,
        constraint uq_person_dni unique (dni),
        constraint uq_person_email unique (email),
        primary key (person_id),
        foreign key (image_id) references images (image_id),
        foreign key (address_id) references addresses (address_id),
        foreign key (business_partner_id) references business_partners (business_partner_id)
    );

go
create table
    roles (
        role_id int identity (1, 1) not null,
        role_name varchar(50) not null,
        constraint uq_role unique (role_name),
        primary key (role_id)
    );

go
create table
    users (
        user_id int identity (1, 1) not null,
        activity_status bit default (1) not null,
        username varchar(50) not null,
        user_password varchar(50) not null,
        constraint uq_user unique (username),
        primary key (user_id)
    );

go
create table
    user_role_rel (
        user_id int foreign key references users (user_id) not null,
        role_id int foreign key references roles (role_id) not null,
        primary key (user_id, role_id)
    );

go
create table
    employees (
        organization_id int not null,
        employee_id int not null,
        admission_date date default cast(getdate () as date) not null,
        user_id int null,
        primary key (organization_id, employee_id),
        foreign key (organization_id) references organizations (organization_id),
        foreign key (employee_id) references people (person_id),
        foreign key (user_id) references users (user_id)
    );

go