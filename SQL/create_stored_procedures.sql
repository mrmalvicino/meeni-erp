use meeni_erp_db;

------------
-- IMAGES --
------------

go
create or alter procedure sp_create_image(
    @image_url varchar(300)
)
as
begin
    insert into
        images (image_url)
        output inserted.image_id
    values
        (@image_url);
end;

---------------
-- COUNTRIES --
---------------

go
create or alter procedure sp_create_country(
    country_name varchar(50)
)
as
begin
    insert into
        countries (country_name)
        output inserted.country_id
    values
        (@country_name);
end;

---------------
-- PROVINCES --
---------------

go
create or alter procedure sp_create_province(
    province_name varchar(50),
    country_id int
)
as
begin
    insert into
        provinces (province_name, country_id)
        output inserted.province_id
    values
        (@province_name, @country_id);
end;

------------
-- CITIES --
------------

go
create or alter procedure sp_create_city(
    @city_name varchar(50),
    @zip_code varchar(10),
    @province_id int
)
as
begin
    insert into
        cities (city_name, zip_code, province_id)
        output inserted.city_id
    values
        (@city_name, @zip_code, @province_id);
end;

---------------
-- ADDRESSES --
---------------

go
create or alter procedure sp_create_address(
    @street_name varchar(50),
    @street_number varchar(10),
    @flat varchar(10),
    @details varchar(300),
    @city_id int
)
as
begin
    insert into
        addresses (street_name, street_number, flat, details, city_id)
        output inserted.address_id
    values
        (@street_name, @street_number, @flat, @details, @city_id);
end;

--------------------
-- LEGAL ENTITIES --
--------------------

go
create or alter procedure sp_create_legal_entity(
    @cuit varchar(11),
    @legal_entity_name varchar(50),
    @email varchar(50),
    @phone varchar(50),
    @logo_image_id int,
    @address_id int
)
as
begin
    insert into
        legal_entities (cuit, legal_entity_name, email, phone, logo_image_id, address_id)
        output inserted.legal_entity_id
    values
        (@cuit, @legal_entity_name, @email, @phone, @logo_image_id, @address_id);
end;

-------------------
-- PRICING PLANS --
-------------------

----------------------------
-- INTERNAL ORGANIZATIONS --
----------------------------
go
create or alter procedure sp_create_internal_organization(
    @internal_organization_id int,
    @pricing_plan_id int
)
as
begin
    insert into
        internal_organizations (internal_organization_id, pricing_plan_id)
        output inserted.internal_organization_id
    values
        (@internal_organization_id, @pricing_plan_id);
end;

----------------------------
-- EXTERNAL ORGANIZATIONS --
----------------------------

------------
-- PEOPLE --
------------

-----------------------
-- BUSINESS PARTNERS --
-----------------------

---------------
-- EMPLOYEES --
---------------

go
create or alter procedure sp_create_employee(
    @employee_id int
)
as
begin
    insert into
        employees (employee_id)
        output inserted.employee_id
    values
        (@employee_id);
end;

-----------
-- ROLES --
-----------

go
create or alter procedure sp_list_roles(
    @user_id int
)
as
begin
    if (@user_id = 0)
    begin
        select * from roles;
        return;
    end

    select
        R.role_id,
        R.role_name
    from
        roles R
        inner join user_role_rel X on R.role_id = X.role_id
    where
        X.user_id = @user_id;
end;

-----------
-- USERS --
-----------
go
create or alter procedure sp_create_user(
    @user_id int,
    @username varchar(50),
    @password varchar(50)
)
as
begin
    insert into
        users (user_id, username, password)
        output inserted.user_id
    values
        (@user_id, @username, @password);
end;

go
create or alter procedure sp_find_user_id(
    @username varchar(50),
    @password varchar(50)
)
as
begin
    select
        user_id
    from
        users
    where
        username = @username
        and password = @password;
end;

-------------------
-- USERS X ROLES --
-------------------

go
create or alter procedure sp_create_user_role(
    @user_id int,
    @role_id int
)
as
begin
    insert into
        user_role_rel (user_id, role_id)
    values
        (@user_id, @role_id);
end;

go