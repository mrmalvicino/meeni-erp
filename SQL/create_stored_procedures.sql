use meeni_erp_db;

go
create or alter procedure sp_create_organization(
    @organization_name varchar(50),
    @logo_image_id int,
    @pricing_plan_id int
)
as
begin
    insert into
        organizations (organization_name, logo_image_id, pricing_plan_id)
        output inserted.organization_id
    values
        (@organization_name, @logo_image_id, @pricing_plan_id);
end;

go
create or alter procedure sp_create_user(
    @username varchar(50),
    @user_password varchar(50),
    @organization_id int
)
as
begin
    insert into
        users (username, user_password, organization_id)
        output inserted.user_id
    values
        (@username, @user_password, @organization_id);
end;

go
create or alter procedure sp_list_user_roles(
    @user_id int
)
as
begin
    select
        R.role_id,
        R.role_name
    from
        roles R
        inner join user_role_rel X on R.role_id = X.role_id
    where
        X.user_id = @user_id;
end;

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
create or alter procedure sp_find_user_id(
    @username varchar(50),
    @user_password varchar(50)
)
as
begin
    select
        user_id
    from
        users
    where
        username = @username
        and user_password = @user_password;
end;

go