
CREATE Procedure [dbo].[GetPendingSummary] AS begin

SELECT tc.TicketCategory,t.Zone, count(*) as Arrived
from [dbo].[TicketsIssued] t
LEFT JOIN dbo.TicketCategory tc on t.Category = tc.TicketCategoryCode
where [ArrivedAt] is null
group by  tc.TicketCategory,Zone

END