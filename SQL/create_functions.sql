use meeni_erp_db;

go

print '';

print 'Creating fn_get_wanted_status function...';

go
create or alter function dbo.fn_get_wanted_status(
    @list_active bit,
    @list_inactive bit
)
returns varchar(3)
as
begin
    declare @result varchar(3);

    if (@list_active = 1 and @list_inactive = 0)
    begin
        set @result = '1,1';
    end
    else if (@list_active = 0 and @list_inactive = 1)
    begin
        set @result = '0,0';
    end
    else if (@list_active = 1 and @list_inactive = 1)
    begin
        set @result = '1,0';
    end

    return @result;
end;

go