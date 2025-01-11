@echo off
setlocal enabledelayedexpansion

:menu
cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo This script will delete the current local database and run SQL scripts to generate it from scratch.
echo.
echo Press any key to continue...
pause >nul

cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo Choose database host:
echo.
echo 1- Localhost
echo 2- Bangho
echo 3- Docker
echo.

set /p choice=Enter your choice (1, 2 or 3):

if "%choice%"=="1" (
    set database_host="localhost\SQLEXPRESS"
) else if "%choice%"=="2" (
    set database_host="BANGHO\SQLEXPRESS"
) else if "%choice%"=="3" (
    set database_host=192.168.0.156 -U SA -P Password1234
) else (
    echo Invalid option. Please try again.
    goto menu
)

cls
echo --------------
echo RESET DATABASE
echo --------------
echo.
echo The selected host data is: %database_host%
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

sqlcmd -S %database_host% -i delete_database.sql
sqlcmd -S %database_host% -i create_database.sql
sqlcmd -S %database_host% -i collate_UTF8.sql
sqlcmd -S %database_host% -i create_tables.sql -f 65001
sqlcmd -S %database_host% -i create_functions.sql -f 65001
sqlcmd -S %database_host% -i create_stored_procedures.sql -f 65001
sqlcmd -S %database_host% -i create_views.sql -f 65001
sqlcmd -S %database_host% -i insert_initial_data.sql -f 65001
sqlcmd -S %database_host% -i insert_dummy_data.sql -f 65001

echo.
pause