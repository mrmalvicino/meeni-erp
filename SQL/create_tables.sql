use meeni_erp_db;

go
create table
    countries (
        country_id int primary key identity (1, 1) not null,
        country_name varchar(50) unique not null
    );

go
create table
    provinces (
        province_id int primary key identity (1, 1) not null,
        province_name varchar(50) not null,
        country_id int foreign key references countries (country_id) not null,
        constraint uq_province unique (province_name, country_id)
    );

go
create table
    cities (
        city_id int primary key identity (1, 1) not null,
        city_name varchar(50) not null,
        zip_code varchar(50) null,
        province_id int foreign key references provinces (province_id) not null,
        constraint uq_city unique (city_name, province_id)
    );

go
create table
    addresses (
        address_id int primary key identity (1, 1) not null,
        street_name varchar(50) not null,
        street_number varchar(10) not null,
        flat varchar(50) null,
        details varchar(500) null,
        city_id int foreign key references cities (city_id) not null,
        constraint uq_adress unique (street_name, street_number, flat, city_id)
    );

go
create table
    people (
        person_id int primary key identity (1, 1) not null,
        dni varchar(50) unique null,
        first_name varchar(50) not null,
        last_name varchar(50) not null,
        email varchar(50) unique not null,
        phone varchar(50) null,
        birth_date date null,
        address_id int foreign key references addresses (address_id) null
    );

go
create table
    clients (
        client_id int primary key identity (1, 1) not null,
        activity_status bit default (1) not null,
        person_id int foreign key references people (person_id) not null
    );

go
create table
    suppliers (
        supplier_id int primary key identity (1, 1) not null,
        activity_status bit default (1) not null,
        person_id int foreign key references people (person_id) not null
    );

go
create table
    images (
        image_id int primary key identity (1, 1) not null,
        image_url varchar(500) unique not null
    );

go
create table
    pricing_plans (
        pricing_plan_id int primary key identity (1, 1) not null,
        pricing_plan_name varchar(50) unique not null,
        monthly_fee money check (0 <= monthly_fee) not null
    );

go
create table
    organizations (
        organization_id int primary key identity (1, 1) not null,
        activity_status bit default (1) not null,
        organization_name varchar(50) not null,
        logo_image_id int foreign key references images (image_id) null,
        pricing_plan_id int foreign key references pricing_plans (pricing_plan_id) not null
    );

go
create table
    roles (
        role_id int primary key identity (1, 1) not null,
        role_name varchar(50) not null
    );

go
create table
    users (
        user_id int primary key identity (1, 1) not null,
        activity_status bit default (1) not null,
        username varchar(50) unique not null,
        user_password varchar(50) not null,
        organization_id int foreign key references organizations (organization_id) not null
    );

go
create table
    user_role_rel (
        user_id int foreign key references users (user_id) not null,
        role_id int foreign key references roles (role_id) not null,
        primary key (user_id, role_id)
    );

go