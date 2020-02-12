SET IDENTITY_INSERT [dbo].[CompanyOwner] ON
INSERT INTO [dbo].[CompanyOwner] ([Id], [Name], [ContactEmail]) VALUES (1, N'Jack Wilson', N'jack@company.com')
INSERT INTO [dbo].[CompanyOwner] ([Id], [Name], [ContactEmail]) VALUES (2, N'Kevin Peterson', N'kevin@company.com')
SET IDENTITY_INSERT [dbo].[CompanyOwner] OFF
SET IDENTITY_INSERT [dbo].[Company] ON
INSERT INTO [dbo].[Company] ([Id], [CompanyOwnerId], [Name]) VALUES (1, 1, N'InfoZone')
INSERT INTO [dbo].[Company] ([Id], [CompanyOwnerId], [Name]) VALUES (2, 2, N'Auto Magic')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([Id], [Name], [Email]) VALUES (1, N'James Raymond', N'james@company.com')
INSERT INTO [dbo].[Employee] ([Id], [Name], [Email]) VALUES (2, N'Philip Hays', N'philip@company.com')
SET IDENTITY_INSERT [dbo].[Employee] OFF
SET IDENTITY_INSERT [dbo].[CompanyEmployeeRegistration] ON
INSERT INTO [dbo].[CompanyEmployeeRegistration] ([Id], [CompanyId], [EmployeeId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[CompanyEmployeeRegistration] ([Id], [CompanyId], [EmployeeId]) VALUES (2, 2, 2)
SET IDENTITY_INSERT [dbo].[CompanyEmployeeRegistration] OFF
