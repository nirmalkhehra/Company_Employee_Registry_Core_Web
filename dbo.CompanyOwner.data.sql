SET IDENTITY_INSERT [dbo].[CompanyOwner] ON
INSERT INTO [dbo].[CompanyOwner] ([Id], [Name], [ContactEmail]) VALUES (1, N'Jack Wilson', N'jack@company.com')
INSERT INTO [dbo].[CompanyOwner] ([Id], [Name], [ContactEmail]) VALUES (2, N'Kevin Peterson', N'kevin@company.com')
SET IDENTITY_INSERT [dbo].[CompanyOwner] OFF
