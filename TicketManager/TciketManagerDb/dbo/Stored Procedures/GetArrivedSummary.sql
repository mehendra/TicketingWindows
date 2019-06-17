CREATE Procedure [dbo].[GetArrivedSummary] AS begin

SELECT tc.TicketCategory, count(*) as Arrived
from [dbo].[TicketsIssued] t
LEFT JOIN dbo.TicketCategory tc on t.Category = tc.TicketCategoryCode
where [ArrivedAt] is not null
group by  tc.TicketCategory

END