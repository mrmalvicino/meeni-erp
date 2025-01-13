use meeni_erp_db;

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