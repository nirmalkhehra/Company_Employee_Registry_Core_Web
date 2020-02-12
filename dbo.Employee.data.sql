SET IDENTITY_INSERT [dbo].[Employee] ON
INSERT INTO [dbo].[Employee] ([Id], [Name], [Email]) VALUES (1, N'James Raymond', N'james@company.com')
INSERT INTO [dbo].[Employee] ([Id], [Name], [Email]) VALUES (2, N'Philip Hays', N'philip@company.com')
SET IDENTITY_INSERT [dbo].[Employee] OFF
