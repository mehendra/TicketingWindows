﻿USE [MMunasinghe_Ticketing]
GO
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'AMIL', N'Amila')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'CHAD', N'Chadz')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'CHAN', N'Chanaka')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'DHAR', N'Dharshi')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'DOOR', N'Sold at door')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'HARI', N'Haritha')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'HARS', N'Harsha')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'JAYD', N'Jayasena')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'MANO', N'Manori')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'NONE', N'Unassigned')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'RAVI', N'Ravi')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'SARA', N'Sarath')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'SHAK', N'Shashika')
INSERT [dbo].[Agent] ([AgentCode], [AgentName]) VALUES (N'SHAN', N'Shasinda')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'GEN', N'General Adult - 60')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'KID', N'General Kid - 20')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'VIP', N'Gold - 110')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'USP', N'Unspecified')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'UN5', N'Under Five')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'SCH', N'Seated Child - 30')
INSERT [dbo].[TicketCategory] ([TicketCategoryCode], [TicketCategory]) VALUES (N'SIA', N'Seated Adult - 75')
INSERT [dbo].[TicketSiteUser] ([UserName], [Password], [Role]) VALUES (N'amila', N'FridayThe13', N'Admin')
INSERT [dbo].[TicketSiteUser] ([UserName], [Password], [Role]) VALUES (N'mehendra', N'mehendra2008', N'Admin')
INSERT [dbo].[TicketSiteUser] ([UserName], [Password], [Role]) VALUES (N'shashika', N'RobinHood', N'Admin')
INSERT [dbo].[TicketSiteUser] ([UserName], [Password], [Role]) VALUES (N'dharshi', N'rogue1979', N'Admin')
INSERT [dbo].[TicketStatus] ([TicketStatusCode], [TicketStatus]) VALUES (N'CANC', N'Cancelled')
INSERT [dbo].[TicketStatus] ([TicketStatusCode], [TicketStatus]) VALUES (N'INIT', N'Initial Creation')
INSERT [dbo].[TicketStatus] ([TicketStatusCode], [TicketStatus]) VALUES (N'ISSU', N'Issued')
INSERT [dbo].[TicketStatus] ([TicketStatusCode], [TicketStatus]) VALUES (N'SCOL', N'Issued and Unpaid')
INSERT [dbo].[TicketStatus] ([TicketStatusCode], [TicketStatus]) VALUES (N'SPAD', N'Sold and Paid')