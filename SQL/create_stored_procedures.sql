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
    values
        (@organization_name, @logo_image_id, @pricing_plan_id);
end;

go
create or alter procedure sp_create_user(
    @username varchar(50),
    @user_password varchar(50)
)
as
begin
    insert into
        users (username, user_password)
    values
        (@username, @user_password);
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