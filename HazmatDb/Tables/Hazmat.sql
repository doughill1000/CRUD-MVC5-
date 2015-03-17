CREATE TABLE [dbo].[Hazmat]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Trans#] FLOAT NULL, 
    [Void] BIT NULL, 
    [Date] DATETIME NULL, 
    [Inititals] CHAR(2) NULL, 
    [Material] VARCHAR(50) NULL, 
    [New/Distilled/Dark] VARCHAR(10) NULL, 
    [Quantity] FLOAT NULL, 
    [Gallon/Pound] VARCHAR(10) NULL, 
    [Destination] VARCHAR(50) NULL, 
    [RequestedBy] CHAR(2) NULL, 
    [Shift] VARCHAR(10) NULL, 
    [RequiredFor] VARCHAR(15) NULL, 
    [Notes] VARCHAR(255) NULL
)
