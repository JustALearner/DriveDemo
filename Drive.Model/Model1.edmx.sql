
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/05/2019 12:15:12
-- Generated from EDMX file: D:\repos\DriveDemo\Drive.Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DriveDemo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[T_Sys_Oper_Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Sys_Oper_Log];
GO
IF OBJECT_ID(N'[dbo].[T_Sys_User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[T_Sys_User];
GO
IF OBJECT_ID(N'[drivingModelStoreContainer].[T_Sys_Role]', 'U') IS NOT NULL
    DROP TABLE [drivingModelStoreContainer].[T_Sys_Role];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'T_Sys_Oper_Log'
CREATE TABLE [dbo].[T_Sys_Oper_Log] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [UserCode] varchar(20)  NOT NULL,
    [UserName] varchar(50)  NULL,
    [LogType] varchar(20)  NULL,
    [CreateTime] datetime  NULL,
    [Content] varchar(4000)  NULL
);
GO

-- Creating table 'T_Sys_User'
CREATE TABLE [dbo].[T_Sys_User] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [UserCode] varchar(20)  NOT NULL,
    [UserName] varchar(50)  NULL,
    [Password] varchar(50)  NULL,
    [UserType] varchar(5)  NULL,
    [Telephone] varchar(50)  NULL
);
GO

-- Creating table 'T_Sys_Role'
CREATE TABLE [dbo].[T_Sys_Role] (
    [id] int IDENTITY(1,1) NOT NULL,
    [usercode] varchar(50)  NOT NULL,
    [role] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'T_Sys_Oper_Log'
ALTER TABLE [dbo].[T_Sys_Oper_Log]
ADD CONSTRAINT [PK_T_Sys_Oper_Log]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'T_Sys_User'
ALTER TABLE [dbo].[T_Sys_User]
ADD CONSTRAINT [PK_T_Sys_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id], [usercode] in table 'T_Sys_Role'
ALTER TABLE [dbo].[T_Sys_Role]
ADD CONSTRAINT [PK_T_Sys_Role]
    PRIMARY KEY CLUSTERED ([id], [usercode] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------