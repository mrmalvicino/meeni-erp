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

go
create or alter procedure sp_update_image(
    @image_id int,
    @image_url varchar(300)
)
as
begin
    update images
    set
        image_url = @image_url
    where
        image_id = @image_id;
end;

go
create or alter procedure sp_find_image_id(
    @image_url varchar(300)
)
as
begin
    select
        image_id
    from
        images
    where
        image_url = @image_url;
end;

---------------
-- COUNTRIES --
---------------

go
create or alter procedure sp_create_country(
    @country_name varchar(50)
)
as
begin
    insert into
        countries (country_name)
        output inserted.country_id
    values
        (@country_name);
end;

go
create or alter procedure sp_find_country_id(
    @country_name varchar(50)
)
as
begin
    select
        country_id
    from
        countries
    where
        country_name = @country_name;
end;

---------------
-- PROVINCES --
---------------

go
create or alter procedure sp_create_province(
    @province_name varchar(50),
    @country_id int
)
as
begin
    insert into
        provinces (province_name, country_id)
        output inserted.province_id
    values
        (@province_name, @country_id);
end;

go
create or alter procedure sp_find_province_id(
    @province_name varchar(50),
    @country_id int
)
as
begin
    select
        province_id
    from
        provinces
    where
        province_name = @province_name
        and country_id = @country_id;
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

go
create or alter procedure sp_find_city_id(
    @city_name varchar(50),
    @province_id int
)
as
begin
    select
        city_id
    from
        cities
    where
        city_name = @city_name
        and province_id = @province_id;
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

go
create or alter procedure sp_update_address(
    @address_id int,
    @street_name varchar(50),
    @street_number varchar(10),
    @flat varchar(10),
    @details varchar(300),
    @city_id int
)
as
begin
    update addresses
    set
        street_name = @street_name,
        street_number = @street_number,
        flat = @flat,
        details = @details,
        city_id = @city_id
    where
        address_id = @address_id;
end;

go
create or alter procedure sp_find_address_id(
    @street_name varchar(50),
    @street_number varchar(10),
    @flat varchar(10),
    @city_id int
)
as
begin
    select
        address_id
    from
        addresses
    where
        street_name = @street_name
        and street_number = @street_number
        and flat = @flat
        and city_id = @city_id;
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

go
create or alter procedure sp_update_legal_entity(
    @legal_entity_id int,
    @cuit varchar(11),
    @legal_entity_name varchar(50),
    @email varchar(50),
    @phone varchar(50),
    @logo_image_id int,
    @address_id int
)
as
begin
    update legal_entities
    set
        cuit = @cuit,
        legal_entity_name = @legal_entity_name,
        email = @email,
        phone = @phone,
        logo_image_id = @logo_image_id,
        address_id = @address_id
    where
        legal_entity_id = @legal_entity_id;
end;

-------------------
-- PRICING PLANS --
-------------------

go
create or alter procedure sp_find_pricing_plan_id(
    @pricing_plan_name varchar(50)
)
as
begin
    select
        pricing_plan_id
    from
        pricing_plans
    where
        pricing_plan_name = @pricing_plan_name;
end;

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

go
create or alter procedure sp_update_internal_organization(
    @internal_organization_id int,
    @pricing_plan_id int
)
as
begin
    update internal_organizations
    set
        pricing_plan_id = @pricing_plan_id
    where
        internal_organization_id = @internal_organization_id;
end;

go
create or alter procedure sp_toggle_internal_organization(
    @internal_organization_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        internal_organizations
    where
        internal_organization_id = @internal_organization_id;

    update internal_organizations
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        internal_organization_id = @internal_organization_id;
end;

----------------------------
-- EXTERNAL ORGANIZATIONS --
----------------------------

go
create or alter procedure sp_find_organization_internal_id(
    @external_organization_id int
)
as
begin
    select
        internal_organization_id
    from
        external_organizations
    where
        external_organization_id = @external_organization_id;
end;

------------
-- PEOPLE --
------------

go
create or alter procedure sp_create_person(
    @dni varchar(8),
    @cuil varchar(11),
    @first_name varchar(50),
    @last_name varchar(50),
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @profile_image_id int,
    @address_id int,
    @internal_organization_id int
)
as
begin
    insert into
        people (
            dni,
            cuil,
            first_name,
            last_name,
            email,
            phone,
            birth_date,
            profile_image_id,
            address_id,
            internal_organization_id
        ) output inserted.person_id
    values
        (
            @dni,
            @cuil,
            @first_name,
            @last_name,
            @email,
            @phone,
            @birth_date,
            @profile_image_id,
            @address_id,
            @internal_organization_id
        );
end;

go
create or alter procedure sp_update_person(
    @person_id int,
    @dni varchar(8),
    @cuil varchar(11),
    @first_name varchar(50),
    @last_name varchar(50),
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @profile_image_id int,
    @address_id int
)
as
begin
    update people
    set
        dni = @dni,
        cuil = @cuil,
        first_name = @first_name,
        last_name = @last_name,
        email = @email,
        phone = @phone,
        birth_date = @birth_date,
        profile_image_id = @profile_image_id,
        address_id = @address_id
    where
        person_id = @person_id;
end;

go
create or alter procedure sp_find_person_id(
    @dni varchar(8),
    @internal_organization_id int
)
as
begin
    select
        person_id
    from
        people
    where
        dni = @dni
        and internal_organization_id = @internal_organization_id;
end;

go
create or alter procedure sp_find_person_internal_id(
    @person_id int
)
as
begin
    select
        internal_organization_id
    from
        people
    where
        person_id = @person_id;
end;

-----------------------
-- BUSINESS PARTNERS --
-----------------------

go
create or alter procedure sp_list_business_partners(
    @list_clients bit,
    @list_suppliers bit,
    @list_people bit,
    @internal_organization_id int
)
as
begin
    if (@list_people = 1)
    begin
        select
            *
        from
            business_partners BP
            inner join people P on P.person_id = BP.person_id
        where
            BP.is_client = @list_clients
            and BP.is_supplier = @list_suppliers
            and BP.external_organization_id is null
            and BP.person_id is not null
            and P.internal_organization_id = @internal_organization_id;
    end;

    if (@list_people = 0)
    begin
        select
            *
        from
            business_partners BP
            inner join external_organizations EO on EO.external_organization_id = BP.external_organization_id
        where
            BP.is_client = @list_clients
            and BP.is_supplier = @list_suppliers
            and BP.external_organization_id is not null
            and BP.person_id is null
            and EO.internal_organization_id = @internal_organization_id;
    end;
end;

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

go
create or alter procedure sp_update_employee(
    @employee_id int
)
as
begin
    update employees
    set
        employee_id = @employee_id
    where
        employee_id = @employee_id;
end;

go
create or alter procedure sp_toggle_employee(
    @employee_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        employees
    where
        employee_id = @employee_id;

    update employees
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        employee_id = @employee_id;
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
create or alter procedure sp_delete_user(
    @user_id int
)
as
begin
    begin try
        begin transaction;
            delete from user_role_rel
            where
                user_id = @user_id;

            delete from users
            where
                user_id = @user_id;
        commit transaction;
    end try
    begin catch
        rollback transaction;
        raiserror ('Error de transacción.', 16, 1);
    end catch;
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