# Simplified Market Accounting

A Windows Forms market accounting application built with **.NET Framework 4.8** and **Entity Framework 6**.

The app helps track:
- Products and their buy/sell prices
- Customers and sellers
- Buy and sell transactions
- Product/customer/seller totals and simple profit calculations

## Solution structure

- `MarketAccounting` — WinForms UI application (`MarketAccounting.App.csproj`)
- `MarketAccounting.Buisinus` — business logic layer
- `MarketAccounting.DataLayer` — Entity Framework data access layer and repositories
- `MarketAccounting.ViewModels` — shared view models used by UI/data layer
- `MarketAccountingset` / `MarketAccountingSetup` — setup/deployment projects

## Main features

- Product management (add, edit, delete, search)
- Customer and seller management
- New buy and new sell workflow with product selection
- Admin control panel with transaction/product details

## Tech stack

- C#
- .NET Framework 4.8
- Windows Forms
- Entity Framework 6.2
- SQL Server (connection configured to local instance)

## Prerequisites

- Windows machine
- Visual Studio 2022 (or compatible MSBuild tooling for .NET Framework projects)
- SQL Server / LocalDB

## Database configuration

The connection string is configured in:
- `/home/runner/work/Simplified-Market-Accounting/Simplified-Market-Accounting/MarketAccounting/App.config`
- `/home/runner/work/Simplified-Market-Accounting/Simplified-Market-Accounting/MarketAccounting.DataLayer/App.Config`

Default database name: `MarketAccounting_DB`  
Default data source: `.`

Update those values if your SQL Server instance is different.

## Build and run

1. Open `/home/runner/work/Simplified-Market-Accounting/Simplified-Market-Accounting/MarketAccounting.sln` in Visual Studio.
2. Restore NuGet packages.
3. Build the solution.
4. Set `MarketAccounting.App` as startup project.
5. Run the application.

## Admin panel login

The current admin login is hardcoded in:
`/home/runner/work/Simplified-Market-Accounting/Simplified-Market-Accounting/MarketAccounting/AdminCoPa/FrmLogin.cs`

- Username: `hjreza`
- Password: `3994`

## Notes

- This is a classic .NET Framework WinForms project and is intended for Windows environments.
- The repository currently includes generated build artifacts (`bin/`, `obj/`) that are not required for source-level development.
