CREATE PROCEDURE [dbo].[ReportTicketSummary]
	@param1 int = 0,
	@param2 int
AS BEGIN
select a.AgentName, ti.AgentCode, count(*),tc.TicketCategory ,ti.Category, ti.TicketStatusCode, ts.TicketStatus from 
TicketsIssued ti inner join dbo.Agent a on ti.AgentCode = a.AgentCode
inner join dbo.TicketCategory tc on tc.TicketCategoryCode = ti.Category
inner join dbo.TicketStatus ts on ti.TicketStatusCode = ts.TicketStatusCode
group by  a.AgentName,ti.AgentCode, tc.TicketCategory ,ti.Category,ti.TicketStatusCode, ts.TicketStatus 
Order by AgentName
end
