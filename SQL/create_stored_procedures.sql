use meeni_erp_db;

go

------------
-- IMAGES --
------------

print '';

print 'Creating stored procedures related to images table...';

go
create or alter procedure sp_create_image(
    @url varchar(300)
)
as
begin
    insert into
        images (url)
        output inserted.image_id
    values
        (@url);
end;

go
create or alter procedure sp_update_image(
    @image_id int,
    @url varchar(300)
)
as
begin
    update images
    set
        url = @url
    where
        image_id = @image_id;
end;

go
create or alter procedure sp_find_image_id(
    @url varchar(300)
)
as
begin
    select
        image_id
    from
        images
    where
        url = @url;
end;

go

---------------
-- COUNTRIES --
---------------

print '';

print 'Creating stored procedures related to countries table...';

go
create or alter procedure sp_create_country(
    @name varchar(50)
)
as
begin
    insert into
        countries (name)
        output inserted.country_id
    values
        (@name);
end;

go
create or alter procedure sp_update_country(
    @country_id int,
    @name varchar(50)
)
as
begin
    update countries
    set
        name = @name
    where
        country_id = @country_id;
end;

go
create or alter procedure sp_find_country_id(
    @name varchar(50)
)
as
begin
    select
        country_id
    from
        countries
    where
        name = @name;
end;

go

---------------
-- PROVINCES --
---------------

print '';

print 'Creating stored procedures related to provinces table...';

go
create or alter procedure sp_create_province(
    @name varchar(50),
    @country_id int
)
as
begin
    insert into
        provinces (name, country_id)
        output inserted.province_id
    values
        (@name, @country_id);
end;

go
create or alter procedure sp_update_province(
    @province_id int,
    @name varchar(50),
    @country_id int
)
as
begin
    update provinces
    set
        name = @name,
        country_id = @country_id
    where
        province_id = @province_id;
end;

go
create or alter procedure sp_find_province_id(
    @name varchar(50),
    @country_id int
)
as
begin
    select
        province_id
    from
        provinces
    where
        name = @name
        and country_id = @country_id;
end;

go

------------
-- CITIES --
------------

print '';

print 'Creating stored procedures related to cities table...';

go
create or alter procedure sp_create_city(
    @name varchar(50),
    @zip_code varchar(10),
    @province_id int
)
as
begin
    insert into
        cities (name, zip_code, province_id)
        output inserted.city_id
    values
        (@name, @zip_code, @province_id);
end;

go
create or alter procedure sp_update_city(
    @city_id int,
    @name varchar(50),
    @zip_code varchar(10),
    @province_id int
)
as
begin
    update cities
    set
        name = @name,
        zip_code = @zip_code,
        province_id = @province_id
    where
        city_id = @city_id;
end;

go
create or alter procedure sp_find_city_id(
    @name varchar(50),
    @province_id int
)
as
begin
    select
        city_id
    from
        cities
    where
        name = @name
        and province_id = @province_id;
end;

go

---------------
-- ADDRESSES --
---------------

print '';

print 'Creating stored procedures related to addresses table...';

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

go

--------------
-- ENTITIES --
--------------

print '';

print 'Creating stored procedures related to entities table...';

go
create or alter procedure sp_create_entity(
    @name varchar(50),
    @tax_code varchar(11),
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @image_id int,
    @address_id int
)
as
begin
    insert into
        entities (name, tax_code, email, phone, birth_date, image_id, address_id)
        output inserted.entity_id
    values
        (@name, @tax_code, @email, @phone, @birth_date, @image_id, @address_id);
end;

go
create or alter procedure sp_update_entity(
    @entity_id int,
    @name varchar(50),
    @tax_code varchar(11),
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @image_id int,
    @address_id int
)
as
begin
    update entities
    set
        name = @name,
        tax_code = @tax_code,
        email = @email,
        phone = @phone,
        birth_date = @birth_date,
        image_id = @image_id,
        address_id = @address_id
    where
        entity_id = @entity_id;
end;

go

-------------------
-- PRICING PLANS --
-------------------

print '';

print 'Creating stored procedures related to pricing_plans table...';

go
create or alter procedure sp_find_pricing_plan_id(
    @name varchar(50)
)
as
begin
    select
        pricing_plan_id
    from
        pricing_plans
    where
        name = @name;
end;

go

-------------------
-- ORGANIZATIONS --
-------------------

print '';

print 'Creating stored procedures related to organizations table...';

go
create or alter procedure sp_create_organization(
    @organization_id int,
    @pricing_plan_id int
)
as
begin
    insert into
        organizations (organization_id, pricing_plan_id)
        output inserted.organization_id
    values
        (@organization_id, @pricing_plan_id);
end;

go
create or alter procedure sp_update_organization(
    @organization_id int,
    @pricing_plan_id int
)
as
begin
    update organizations
    set
        pricing_plan_id = @pricing_plan_id
    where
        organization_id = @organization_id;
end;

go
create or alter procedure sp_toggle_organization(
    @organization_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        organizations
    where
        organization_id = @organization_id;

    update organizations
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        organization_id = @organization_id;
end;

go

------------------
-- STAKEHOLDERS --
------------------

print '';

print 'Creating stored procedures related to stakeholders table...';

go
create or alter procedure sp_create_stakeholder(
    @stakeholder_id int,
    @organization_id int
)
as
begin
    insert into
        stakeholders (stakeholder_id, organization_id)
        output inserted.stakeholder_id
    values
        (@stakeholder_id, @organization_id);
end;

go
create or alter procedure sp_read_stakeholder(
    @stakeholder_id int
)
as
begin
    select
        *
    from
        stakeholders
    where
        stakeholder_id = @stakeholder_id;
end;

go
create or alter procedure sp_find_organization_id(
    @stakeholder_id int
)
as
begin
    select
        organization_id
    from
        stakeholders
    where
        stakeholder_id = @stakeholder_id;
end;

go

--------------
-- PARTNERS --
--------------

print '';

print 'Creating stored procedures related to partners table...';

go
create or alter procedure sp_create_partner(
    @partner_id int,
    @is_client bit,
    @is_supplier bit
)
as
begin
    insert into
        partners (partner_id, is_client, is_supplier)
        output inserted.partner_id
    values
        (@partner_id, @is_client, @is_supplier);
end;

go
create or alter procedure sp_update_partner(
    @partner_id int,
    @is_client bit,
    @is_supplier bit
)
as
begin
    update partners
    set
        is_client = @is_client,
        is_supplier = @is_supplier
    where
        partner_id = @partner_id;
end;

go
create or alter procedure sp_toggle_partner(
    @partner_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        partners
    where
        partner_id = @partner_id;

    update partners
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        partner_id = @partner_id;
end;

go
create or alter procedure sp_list_partners(
    @list_clients bit,
    @list_suppliers bit,
    @organization_id int,
    @list_active bit,
    @list_inactive bit
)
as
begin
    declare @wanted_status_1 bit;
    declare @wanted_status_2 bit;

    if (@list_active = 1 and @list_inactive = 0)
    begin
        set @wanted_status_1 = 1;
        set @wanted_status_2 = 1;
    end;

    if (@list_active = 0 and @list_inactive = 1)
    begin
        set @wanted_status_1 = 0;
        set @wanted_status_2 = 0;
    end;

    if (@list_active = 1 and @list_inactive = 1)
    begin
        set @wanted_status_1 = 1;
        set @wanted_status_2 = 0;
    end;

    select
        *
    from
        partners P
        inner join stakeholders S on S.stakeholder_id = P.partner_id
    where
        P.is_client = @list_clients
        and P.is_supplier = @list_suppliers
        and S.organization_id = @organization_id
        and (
            P.activity_status = @wanted_status_1
            or P.activity_status = @wanted_status_2
        );
end;

go

---------------
-- EMPLOYEES --
---------------

print '';

print 'Creating stored procedures related to employees table...';

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
    @employee_id int,
    @admission_date date
)
as
begin
    update employees
    set
        admission_date = @admission_date
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

go

-----------
-- ROLES --
-----------

print '';

print 'Creating stored procedures related to roles table...';

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
        R.name
    from
        roles R
        inner join user_role_rel X on R.role_id = X.role_id
    where
        X.user_id = @user_id;
end;

go

-----------
-- USERS --
-----------

print '';

print 'Creating stored procedures related to users table...';

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

go

-------------------
-- USER ROLE REL --
-------------------

print '';

print 'Creating stored procedures related to user_role_rel table...';

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