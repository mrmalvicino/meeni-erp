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
        addresses (
            street_name,
            street_number,
            flat,
            details,
            city_id
        )
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

--------------------------
-- IDENTIFICATION TYPES --
--------------------------

print '';

print 'Creating stored procedures related to identification_types table...';

go
create or alter procedure sp_read_identification_type(
    @identification_type_id int
)
as
begin
    select
        *
    from
        identification_types
    where
        identification_type_id = @identification_type_id;
end;

go
create or alter procedure sp_list_identification_types
as
begin
    select
        *
    from
        identification_types;
end;

go

---------------------
-- IDENTIFICATIONS --
---------------------

print '';

print 'Creating stored procedures related to identifications table...';

go
create or alter procedure sp_create_identification(
    @code varchar(50),
    @identification_type_id int
)
as
begin
    insert into
        identifications (code, identification_type_id)
        output inserted.identification_id
    values
        (@code, @identification_type_id);
end;

go
create or alter procedure sp_update_identification(
    @identification_id int,
    @code varchar(50),
    @identification_type_id int
)
as
begin
    update identifications
    set
        code = @code,
        identification_type_id = @identification_type_id
    where
        identification_id = @identification_id;
end;

go
create or alter procedure sp_find_identification_id(
    @code varchar(50),
    @organization_id int
)
as
begin
    select
        I.identification_id
    from
        identifications I
        inner join entities E on E.identification_id = I.identification_id
        left join organizations O on O.organization_id = E.entity_id
        left join stakeholders S on S.stakeholder_id = E.entity_id
    where
        I.code = @code
        and (
            S.organization_id = @organization_id
            or O.organization_id = @organization_id
        );
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
    @is_organization bit,
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @image_id int,
    @address_id int,
    @identification_id int
)
as
begin
    insert into
        entities (
            name,
            is_organization,
            email,
            phone,
            birth_date,
            image_id,
            address_id,
            identification_id
        )
        output inserted.entity_id
    values
        (@name, @is_organization, @email, @phone, @birth_date, @image_id, @address_id, @identification_id);
end;

go
create or alter procedure sp_update_entity(
    @entity_id int,
    @name varchar(50),
    @is_organization bit,
    @email varchar(50),
    @phone varchar(50),
    @birth_date date,
    @image_id int,
    @address_id int,
    @identification_id int
)
as
begin
    update entities
    set
        name = @name,
        is_organization = @is_organization,
        email = @email,
        phone = @phone,
        birth_date = @birth_date,
        image_id = @image_id,
        address_id = @address_id,
        identification_id = @identification_id
    where
        entity_id = @entity_id;
end;

go
create or alter procedure sp_find_entity_organization_id(
    @entity_id int
)
as
begin
    select
        o.organization_id
    from 
        organizations O
        inner join entities E on O.organization_id = E.entity_id
    where 
        E.entity_id = @entity_id

    union

    select 
        S.organization_id
    from 
        stakeholders S
        inner join entities E on S.stakeholder_id = E.entity_id
    where
        E.entity_id = @entity_id;
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
create or alter procedure sp_update_stakeholder(
    @stakeholder_id int
)
as
begin
    update stakeholders
    set
        stakeholder_id = @stakeholder_id -- provisorio
    where
        stakeholder_id = @stakeholder_id;
end;

go
create or alter procedure sp_find_stakeholder_organization_id(
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
        S.organization_id = @organization_id
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
create or alter procedure sp_list_employees(
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
        employees E
        inner join stakeholders S on S.stakeholder_id = E.employee_id
    where
        S.organization_id = @organization_id
        and (
            E.activity_status = @wanted_status_1
            or E.activity_status = @wanted_status_2
        );
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

------------
-- BRANDS --
------------

print '';

print 'Creating stored procedures related to brands table...';

go
create or alter procedure sp_create_brand(
    @name varchar(50),
    @organization_id int
)
as
begin
    insert into
        brands (name, organization_id)
        output inserted.brand_id
    values
        (@name, @organization_id);
end;

go
create or alter procedure sp_update_brand(
    @brand_id int,
    @name varchar(50)
)
as
begin
    update brands
    set
        name = @name
    where
        brand_id = @brand_id;
end;

go
create or alter procedure sp_toggle_brand(
    @brand_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        brands
    where
        brand_id = @brand_id;

    update brands
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        brand_id = @brand_id;
end;

go
create or alter procedure sp_list_brands(
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
        brands
    where
        organization_id = @organization_id
        and (
            activity_status = @wanted_status_1
            or activity_status = @wanted_status_2
        );
end;

go
create or alter procedure sp_find_brand_id(
    @name varchar(50),
    @organization_id int
)
as
begin
    select
        brand_id
    from
        brands
    where
        name = @name
        and organization_id = @organization_id;
end;

go

--------------
-- PRODUCTS --
--------------

print '';

print 'Creating stored procedures related to products table...';

go
create or alter procedure sp_create_product(
    @is_service bit,
    @name varchar(50),
    @description varchar(300),
    @sku varchar(50),
    @price money,
    @cost money,
    @brand_id int,
    @organization_id int
)
as
begin
    insert into
        products (
            is_service,
            name,
            description,
            sku,
            price,
            cost,
            brand_id,
            organization_id
        )
        output inserted.product_id
    values
        (
            @is_service,
            @name,
            @description,
            @sku,
            @price,
            @cost,
            @brand_id,
            @organization_id
        );
end;

go
create or alter procedure sp_update_product(
    @product_id int,
    @is_service bit,
    @name varchar(50),
    @description varchar(300),
    @sku varchar(50),
    @price money,
    @cost money,
    @brand_id int
)
as
begin
    update products
    set
        is_service = @is_service,
        name = @name,
        description = @description,
        sku = @sku,
        price = @price,
        cost = @cost,
        brand_id = @brand_id
    where
        product_id = @product_id;
end;

go
create or alter procedure sp_toggle_product(
    @product_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        products
    where
        product_id = @product_id;

    update products
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        product_id = @product_id;
end;

go
create or alter procedure sp_list_products(
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
        products
    where
        organization_id = @organization_id
        and (
            activity_status = @wanted_status_1
            or activity_status = @wanted_status_2
        );
end;

go
create or alter procedure sp_find_product_organization_id(
    @product_id int
)
as
begin
    select
        organization_id
    from 
        products
    where
        product_id = @product_id;
end;

go

----------------
-- CATEGORIES --
----------------

print '';

print 'Creating stored procedures related to categories table...';

go
create or alter procedure sp_create_category(
    @name varchar(50),
    @organization_id int
)
as
begin
    insert into
        categories (name, organization_id)
        output inserted.category_id
    values
        (@name, @organization_id);
end;

go
create or alter procedure sp_update_category(
    @category_id int,
    @name varchar(50)
)
as
begin
    update categories
    set
        name = @name
    where
        category_id = @category_id;
end;

go
create or alter procedure sp_toggle_category(
    @category_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        categories
    where
        category_id = @category_id;

    update categories
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        category_id = @category_id;
end;

go
create or alter procedure sp_list_categories(
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
        categories
    where
        organization_id = @organization_id
        and (
            activity_status = @wanted_status_1
            or activity_status = @wanted_status_2
        );
end;

go

--------------------------------
-- PRODUCT-CATEGORY RELATIONS --
--------------------------------

print '';

print 'Creating stored procedures related to product_category_rel table...';

go
create or alter procedure sp_list_product_categories(
    @product_id int
)
as
begin
    select
        C.category_id,
        C.activity_status,
        C.name
    from
        categories C
        inner join product_category_rel X on X.category_id = C.category_id
    where
        C.activity_status = 1
        and X.product_id = @product_id;
end;

go

-----------------------------
-- PRODUCT-IMAGE RELATIONS --
-----------------------------

print '';

print 'Creating stored procedures related to product_image_rel table...';

go

----------------
-- WAREHOUSES --
----------------

print '';

print 'Creating stored procedures related to warehouses table...';

go
create or alter procedure sp_create_warehouse(
    @name varchar(50),
    @address_id int,
    @organization_id int
)
as
begin
    insert into
        warehouses (name, address_id, organization_id)
        output inserted.warehouse_id
    values
        (@name, @address_id, @organization_id);
end;

go
create or alter procedure sp_update_warehouse(
    @warehouse_id int,
    @name varchar(50),
    @address_id int
)
as
begin
    update warehouses
    set
        name = @name,
        address_id = @address_id
    where
        warehouse_id = @warehouse_id;
end;

go
create or alter procedure sp_toggle_warehouse(
    @warehouse_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        warehouses
    where
        warehouse_id = @warehouse_id;

    update warehouses
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        warehouse_id = @warehouse_id;
end;

go
create or alter procedure sp_list_warehouses(
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
        warehouses
    where
        organization_id = @organization_id
        and (
            activity_status = @wanted_status_1
            or activity_status = @wanted_status_2
        );
end;

go
create or alter procedure sp_find_warehouse_organization_id(
    @warehouse_id int
)
as
begin
    select
        organization_id
    from
        warehouses
    where
        warehouse_id = @warehouse_id;
end;

go

------------------
-- COMPARTMENTS --
------------------

print '';

print 'Creating stored procedures related to compartments table...';

go
create or alter procedure sp_create_compartment(
    @name varchar(50),
    @stock int,
    @product_id int,
    @warehouse_id int
)
as
begin
    insert into
        compartments (name, stock, product_id, warehouse_id)
        output inserted.compartment_id
    values
        (@name, @stock, @product_id, @warehouse_id);
end;

go
create or alter procedure sp_update_compartment(
    @compartment_id int,
    @name varchar(50),
    @stock int,
    @product_id int,
    @warehouse_id int
)
as
begin
    update compartments
    set
        name = @name,
        stock = @stock,
        product_id = @product_id,
        warehouse_id = @warehouse_id
    where
        compartment_id = @compartment_id;
end;

go
create or alter procedure sp_toggle_compartment(
    @compartment_id int
)
as
begin
    declare @current_status int;

    select
        @current_status = activity_status
    from
        compartments
    where
        compartment_id = @compartment_id;

    update compartments
    set
        activity_status = case when @current_status = 1 then 0 else 1 end
    where
        compartment_id = @compartment_id;
end;

go
create or alter procedure sp_list_compartments(
    @warehouse_id int,
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
        compartments
    where
        warehouse_id = @warehouse_id
        and (
            activity_status = @wanted_status_1
            or activity_status = @wanted_status_2
        );
end;

go