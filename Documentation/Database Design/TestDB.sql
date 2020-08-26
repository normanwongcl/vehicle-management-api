CREATE TABLE [dbo].[VehicleType]
(
	[VehicleTypeId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
        [VehicleTypeName]  NVARCHAR(20) NOT NULL
)

CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    	[Make] NVARCHAR(20) NOT NULL, 
    	[Model] NVARCHAR(20) NOT NULL, 
    	[Price] smallmoney NOT NULL,
        [VehicleTypeId] int,
        constraint [FK_VehicleId] foreign key ([VehicleTypeId]) references [dbo].[VehicleType](VehicleTypeId)
)

INSERT INTO [dbo].[VehicleType] (VehicleTypeName)
VALUES ('Car')


INSERT INTO [dbo].[VehicleType] (VehicleTypeName)
VALUES ('Boat')


INSERT INTO [dbo].[Vehicle] (Make, Model, Price, VehicleTypeId) 
                                     VALUES ('Toyota', 'Camry', 321.3, 1);

INSERT INTO [dbo].[Vehicle] (Make, Model, Price, VehicleTypeId) 
                                     VALUES ('Toyota', 'Prius', 321.3, 1);
SELECT * FROM dbo.Vehicle
SELECT * FROM dbo.VehicleType
