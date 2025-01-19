@echo off
setlocal enabledelayedexpansion

cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo This script will delete the current database and run SQL scripts to generate it from scratch.
echo.
echo Press any key to continue...
pause >nul

:menu
cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo Choose database host:
echo.
echo 1- Default localhost
echo 2- Local server with integrated security
echo 3- External server using credentials
echo.
echo Enter your choice (1, 2 or 3):

set /p choice=

if "%choice%"=="1" (
    set database_host=localhost\SQLEXPRESS
) else if "%choice%"=="2" (
    echo Enter custom SQL Express path:
    set /p local_path=
    set database_host=!local_path!\SQLEXPRESS
) else if "%choice%"=="3" (
    echo Enter IP or web address:
    set /p server_ip_address=
    echo Enter database username:
    set /p server_username=
    echo Enter database password:
    set /p server_password=
    set database_host=!server_ip_address! -U !server_username! -P !server_password!
) else (
    echo Invalid option. Please try again.
    goto menu
)

cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo The selected host data is: !database_host!
echo.
echo Do you really want to overwrite the current database?
echo.
set /p confirm=Enter your choice (Y/N):

if /i "%confirm%" NEQ "Y" (
    echo Cancelled by user.
    pause
    goto menu
)

cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo [1] Deleting database...
echo.
sqlcmd -S !database_host! -i delete_database.sql
echo.
echo [2] Creating database...
echo.
sqlcmd -S !database_host! -i create_database.sql
echo [3] Collating UTF8...
echo.
sqlcmd -S !database_host! -i collate_UTF8.sql
echo.
echo [4] Creating tables...
echo.
sqlcmd -S !database_host! -i create_tables.sql -f 65001
echo.
echo [5] Creating functions...
echo.
sqlcmd -S !database_host! -i create_functions.sql -f 65001
echo.
echo [6] Creating stored procedures...
echo.
sqlcmd -S !database_host! -i create_stored_procedures.sql -f 65001
echo.
echo [7] Creating views...
echo.
sqlcmd -S !database_host! -i create_views.sql -f 65001
echo.
echo [8] Inserting initial data...
echo.
sqlcmd -S !database_host! -i insert_initial_data.sql -f 65001
echo.
echo [9] Inserting dummy data...
echo.
sqlcmd -S !database_host! -i insert_dummy_data.sql -f 65001
echo.
pause