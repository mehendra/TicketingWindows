USE Ticketing

TRUNCATE TABLE [dbo].[TicketsIssued]
GO

SET IDENTITY_INSERT [dbo].[TicketsIssued]  ON
GO

INSERT INTO [dbo].[TicketsIssued] 
		([TicketNumber]
      ,[AgentCode]
      ,[Category]
      ,[TicketStatusCode]
      ,[ArrivedAt]
      ,[ArrivalConfirmedBy]
      ,[Paid]
      ,[Notes]
      ,[SoldTo]
      ,[Zone]
      ,[TicketId])
SELECT [TicketNumber]
      ,[AgentCode]
      ,[Category]
      ,[TicketStatusCode]
      ,[ArrivedAt]
      ,[ArrivalConfirmedBy]
      ,[Paid]
      ,[Notes]
      ,[SoldTo]
      ,[Zone]
      ,[TicketId]
	  FROM TicketingBK.[dbo].TicketsIssued

GO
SET IDENTITY_INSERT [dbo].[TicketsIssued]  OFF
