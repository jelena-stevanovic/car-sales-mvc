USE [CarSelling]
GO
SET IDENTITY_INSERT [dbo].[BodyTypes] ON 

INSERT [dbo].[BodyTypes] ([Id], [Name]) VALUES (1, N'Hatchback')
INSERT [dbo].[BodyTypes] ([Id], [Name]) VALUES (2, N'Coupe')
INSERT [dbo].[BodyTypes] ([Id], [Name]) VALUES (3, N'Sedan')
INSERT [dbo].[BodyTypes] ([Id], [Name]) VALUES (4, N'SUV')
SET IDENTITY_INSERT [dbo].[BodyTypes] OFF
SET IDENTITY_INSERT [dbo].[FuelTypes] ON 

INSERT [dbo].[FuelTypes] ([Id], [Name]) VALUES (1, N'Gasoline')
INSERT [dbo].[FuelTypes] ([Id], [Name]) VALUES (2, N'Diesel')
INSERT [dbo].[FuelTypes] ([Id], [Name]) VALUES (3, N'Bio-diesel')
SET IDENTITY_INSERT [dbo].[FuelTypes] OFF
SET IDENTITY_INSERT [dbo].[Makes] ON 

INSERT [dbo].[Makes] ([Id], [Name]) VALUES (1, N'Audi')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (2, N'Citroen')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (3, N'BMW')
INSERT [dbo].[Makes] ([Id], [Name]) VALUES (4, N'Dacia')
SET IDENTITY_INSERT [dbo].[Makes] OFF
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (1, N'A4', N'~/ImageUpload/659281fd-f4d4-4a40-a399-7ca60c0e6366.jpg', 201, 2022, CAST(39100.0000 AS Decimal(18, 4)), CAST(2000.0000 AS Decimal(18, 4)), N'The standard features of the Audi A4 40 Premium include 2.0L I - 4 201hp intercooled turbo engine, 7 - speed auto - shift manual transmission with overdrive 4 - wheel anti -lock brakes(ABS), side seat mounted airbags, SIDEGUARD curtain 1st and 2nd row overhead airbags, driver and passenger knee airbag, airbag occupancy sensor, automatic air conditioning, and cruise control.', N'5069324472', 3, 2, 1)
INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (2, N'DS5', N'~/ImageUpload/dbf2f3a3-e732-4d58-997e-904c9e5d4fc7.jpg', 156, 2011, CAST(11450.0000 AS Decimal(18, 4)), CAST(1598.0000 AS Decimal(18, 4)), N'The size of the DS5 is compact (only 4,53 m), and the trunk volume is 468 liters, with the rear seats folded down to 1.288 liters.', N'6046927694', 1, 1, 2)
INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (3, N'Logan', N'~/ImageUpload/3a20cb03-dade-418c-9f60-787f39ab207c.jpg', 90, 2013, CAST(8360.0000 AS Decimal(18, 4)), CAST(1400.0000 AS Decimal(18, 4)), N'The Dacia Logan is a more family oriented vehicle. You get a huge load space – up to 1,518 litres with the seats folded flat – which is bigger than most of its mainstream competitors. ', N'6147274670', 3, 2, 4)
INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (4, N'4', N'~/ImageUpload/cd09419e-9509-4719-bcb2-123df35b0640.jpg', 228, 2021, CAST(39870.0000 AS Decimal(18, 4)), CAST(1983.0000 AS Decimal(18, 4)), N'The 2022 BMW 4 Series blends class and performance in a way that few other luxury small cars can.The BMW 4 Series is an upmarket coupe that seats four. ', N'3063027591', 2, 1, 3)
INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (5, N'A3', N'~/ImageUpload/2872ccba-ccc1-401a-870e-a76bff9d9503.jpg', 110, 2016, CAST(9995.0000 AS Decimal(18, 4)), CAST(1197.0000 AS Decimal(18, 4)), N'This small two-door Audi hatch came equipped with a 2.0-liter turbocharged four-cylinder engine, with an optional diesel power plant.', N'4038889985', 1, 2, 1)
INSERT [dbo].[Cars] ([Id], [Model], [ImagePath], [Power], [Year], [Price], [Displacement], [Description], [Contact], [BodyTypeId], [FuelTypeId], [MakeId]) VALUES (6, N'C5', N'~/ImageUpload/92ebbdc6-5e7b-4d8e-a3e6-9fc6fa143eae.jpg', 130, 2022, CAST(30000.0000 AS Decimal(18, 4)), CAST(1499.0000 AS Decimal(18, 4)), N'Citroen C5 Aircross is currently available in Diesel engine. The 1997 cc Diesel engine generates a power of 174.33@3750rpm and a torque of 400Nm@2000rpm.', N'5062111872', 4, 2, 2)
SET IDENTITY_INSERT [dbo].[Cars] OFF
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'30cfe449-c2c8-463c-aa8d-ddc913b15e93', N'Administrator', N'ADMINISTRATOR', N'd8bbd8dd-4ac9-4947-b97c-103f19cd997d')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fba96aca-765d-48a4-a01e-e3aef86f7562', N'admin', N'ADMIN', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBx4Kpxa0YY+0obhf5QSxiQQRIW89uBl45JH+1UfHMpCvwgBYxYW8rmWa6JyFxEPpA==', N'FEWGHCLKRDA5HQZ23SBHPXQHZLPOVYF4', N'a89778d2-57c2-4b63-bfbb-1e55fd00c0fb', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fba96aca-765d-48a4-a01e-e3aef86f7562', N'30cfe449-c2c8-463c-aa8d-ddc913b15e93')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220407202142_InitialMigration', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220407210811_DataAdded', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220408155016_Initial', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415173302_IdentityAdded', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415174539_Identity', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415175504_IdentityAdded', N'5.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415204649_PriceTypeChanged', N'5.0.0')
