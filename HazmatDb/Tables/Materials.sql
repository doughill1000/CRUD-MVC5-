﻿CREATE TABLE [dbo].[Materials]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [Name] VARCHAR(50) NOT NULL UNIQUE, 
    [Code] VARCHAR(3) NULL UNIQUE
)
