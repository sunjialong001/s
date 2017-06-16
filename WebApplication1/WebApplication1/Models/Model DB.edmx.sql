
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/16/2017 13:49:15
-- Generated from EDMX file: C:\Users\Amour\Source\Repos\s\WebApplication1\WebApplication1\Models\Model DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [master];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KKHObjectSet'
CREATE TABLE [dbo].[KKHObjectSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Isactive] nvarchar(max)  NOT NULL,
    [Timecreate] nvarchar(max)  NOT NULL,
    [Timemodify] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KKHBedSet'
CREATE TABLE [dbo].[KKHBedSet] (
    [Bednumber] int IDENTITY(1,1) NOT NULL,
    [Patientnumber] nvarchar(max)  NOT NULL,
    [Doctornumber] nvarchar(max)  NOT NULL,
    [Nursenumber] nvarchar(max)  NOT NULL,
    [Therapistnumber] nvarchar(max)  NOT NULL,
    [Timein] nvarchar(max)  NOT NULL,
    [Timeout] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KKHSystemSet'
CREATE TABLE [dbo].[KKHSystemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Person] nvarchar(max)  NOT NULL,
    [Room] nvarchar(max)  NOT NULL,
    [Localcase] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KKHPersonSet'
CREATE TABLE [dbo].[KKHPersonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Dayofbirth] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EmployeeSet'
CREATE TABLE [dbo].[EmployeeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Employeenumber] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KKHObjectSet_KKHRoom'
CREATE TABLE [dbo].[KKHObjectSet_KKHRoom] (
    [Roomnumber] int IDENTITY(1,1) NOT NULL,
    [Roomtype] nvarchar(max)  NOT NULL,
    [Bedsnumber] nvarchar(max)  NOT NULL,
    [Timeclosed] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'KKHObjectSet'
ALTER TABLE [dbo].[KKHObjectSet]
ADD CONSTRAINT [PK_KKHObjectSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Bednumber] in table 'KKHBedSet'
ALTER TABLE [dbo].[KKHBedSet]
ADD CONSTRAINT [PK_KKHBedSet]
    PRIMARY KEY CLUSTERED ([Bednumber] ASC);
GO

-- Creating primary key on [Id] in table 'KKHSystemSet'
ALTER TABLE [dbo].[KKHSystemSet]
ADD CONSTRAINT [PK_KKHSystemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KKHPersonSet'
ALTER TABLE [dbo].[KKHPersonSet]
ADD CONSTRAINT [PK_KKHPersonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeSet'
ALTER TABLE [dbo].[EmployeeSet]
ADD CONSTRAINT [PK_EmployeeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KKHObjectSet_KKHRoom'
ALTER TABLE [dbo].[KKHObjectSet_KKHRoom]
ADD CONSTRAINT [PK_KKHObjectSet_KKHRoom]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'KKHObjectSet_KKHRoom'
ALTER TABLE [dbo].[KKHObjectSet_KKHRoom]
ADD CONSTRAINT [FK_KKHRoom_inherits_KKHObject]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[KKHObjectSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------