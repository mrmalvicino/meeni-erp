use meeni_erp_db;

------------
-- IMAGES --
------------

---------------
-- COUNTRIES --
---------------

---------------
-- PROVINCES --
---------------

------------
-- CITIES --
------------

---------------
-- ADDRESSES --
---------------

--------------------
-- LEGAL ENTITIES --
--------------------

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