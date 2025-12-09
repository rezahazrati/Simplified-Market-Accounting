
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/04/2023 18:35:14
-- Generated from EDMX file: D:\programing\projects\repos\MarketAccounting\MarketAccounting.DataLayer\MarketAccountingModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MarketAccounting_DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SlAndBu_TypeId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SlAndBu] DROP CONSTRAINT [FK_SlAndBu_TypeId];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[PWYBF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PWYBF];
GO
IF OBJECT_ID(N'[dbo].[SlAndBu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SlAndBu];
GO
IF OBJECT_ID(N'[dbo].[TypeId]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeId];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(500)  NOT NULL,
    [ProductBuyCost] int  NOT NULL,
    [ProductSellCost] int  NOT NULL,
    [BoughtTillNow] int  NOT NULL,
    [SoldTillNow] int  NOT NULL
);
GO

-- Creating table 'SlAndBu'
CREATE TABLE [dbo].[SlAndBu] (
    [SlAndBuId] int IDENTITY(1,1) NOT NULL,
    [TypeId] int  NOT NULL,
    [NumberOfProduct] int  NOT NULL,
    [TotalCost] int  NOT NULL,
    [DateTime] datetime  NOT NULL,
    [NameOfCustomer] nvarchar(550)  NOT NULL
);
GO

-- Creating table 'TypeId'
CREATE TABLE [dbo].[TypeId] (
    [TypeId1] int  NOT NULL,
    [What] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerId] int IDENTITY(1,1) NOT NULL,
    [CustomerName] nvarchar(550)  NOT NULL,
    [BoughtTillNow] int  NOT NULL
);
GO

-- Creating table 'PWYBF'
CREATE TABLE [dbo].[PWYBF] (
    [PWYBFId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(550)  NOT NULL,
    [SoldTillNow] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- Creating primary key on [SlAndBuId] in table 'SlAndBu'
ALTER TABLE [dbo].[SlAndBu]
ADD CONSTRAINT [PK_SlAndBu]
    PRIMARY KEY CLUSTERED ([SlAndBuId] ASC);
GO

-- Creating primary key on [TypeId1] in table 'TypeId'
ALTER TABLE [dbo].[TypeId]
ADD CONSTRAINT [PK_TypeId]
    PRIMARY KEY CLUSTERED ([TypeId1] ASC);
GO

-- Creating primary key on [CustomerId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerId] ASC);
GO

-- Creating primary key on [PWYBFId] in table 'PWYBF'
ALTER TABLE [dbo].[PWYBF]
ADD CONSTRAINT [PK_PWYBF]
    PRIMARY KEY CLUSTERED ([PWYBFId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TypeId] in table 'SlAndBu'
ALTER TABLE [dbo].[SlAndBu]
ADD CONSTRAINT [FK_SlAndBu_TypeId]
    FOREIGN KEY ([TypeId])
    REFERENCES [dbo].[TypeId]
        ([TypeId1])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SlAndBu_TypeId'
CREATE INDEX [IX_FK_SlAndBu_TypeId]
ON [dbo].[SlAndBu]
    ([TypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------