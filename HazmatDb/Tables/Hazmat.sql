CREATE TABLE [dbo].[Hazmat]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TransactionNum] FLOAT NOT NULL UNIQUE, 
    [Void] BIT NULL, 
    [Date] DATETIME NULL, 
    [Initials] CHAR(2) NULL, 
    [Material] VARCHAR(25) NULL, 
    [New/Distilled] VARCHAR(25) NULL, 
    [Quantity] FLOAT NULL, 
    [Gallon/Pound] VARCHAR(3) NULL, 
    [Destination] VARCHAR(25) NULL, 
    [RequestedBy] CHAR(2) NULL, 
    [Shift] VARCHAR(10) NULL, 
    [RequiredFor] VARCHAR(25) NULL, 
    [Notes] VARCHAR(255) NULL
)
