create procedure ReportTicketSummary
as begin
select a.AgentName, ti.AgentCode, count(*) as NumberOfTickets,tc.TicketCategory ,ti.Category, ti.TicketStatusCode, ts.TicketStatus, ti.Zone
from 
TicketsIssued ti inner join dbo.Agent a on ti.AgentCode = a.AgentCode
inner join dbo.TicketCategory tc on tc.TicketCategoryCode = ti.Category
inner join dbo.TicketStatus ts on ti.TicketStatusCode = ts.TicketStatusCode
group by  a.AgentName,ti.AgentCode, tc.TicketCategory ,ti.Category,ti.TicketStatusCode, ts.TicketStatus,ti.Zone
Order by AgentName
end

