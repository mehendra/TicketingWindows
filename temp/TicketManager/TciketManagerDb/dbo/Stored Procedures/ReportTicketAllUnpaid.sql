create procedure [dbo].[ReportTicketAllUnpaid]
as begin

declare @ticketPrices table
(
	[TicketCategoryCode] varchar(3),
	TicketPrice Money
)

INSERT INTO @ticketPrices(TicketCategoryCode,TicketPrice) 
select 'GEN', 50 union all
select 'KID', 25 union all
select 'ZOA',60 union all
select 'VIP',100 union all
select 'UN',0 union all
select 'ZOB', 60 

select a.AgentName, ti.AgentCode, count(*) as NumberOfTickets,tc.TicketCategory ,ti.Category,  sum(p.TicketPrice) as TotalOwing
from 
TicketsIssued ti inner join dbo.Agent a on ti.AgentCode = a.AgentCode
inner join dbo.TicketCategory tc on tc.TicketCategoryCode = ti.Category
inner join dbo.TicketStatus ts on ti.TicketStatusCode = ts.TicketStatusCode
inner join @ticketPrices p on ti.Category = p.TicketCategoryCode
where ti.TicketStatusCode != 'SPAD'
group by  a.AgentName,ti.AgentCode, tc.TicketCategory ,ti.Category
Order by AgentName
end
