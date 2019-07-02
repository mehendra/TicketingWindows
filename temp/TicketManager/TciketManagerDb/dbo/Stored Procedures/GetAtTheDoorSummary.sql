CREATE PROCEDURE [dbo].[GetAtTheDoorSummary]
AS
BEGIN
DECLARE @TicketArrivedSummary AS TABLE
(
	TicketCategory VARCHAR(255),
	NumberArrived INT DEFAULT(0),
	NumberToArrive INT DEFAULT(0),
	TotalNumberOfTickets INT DEFAULT(0)
)

INSERT INTO @TicketArrivedSummary (TicketCategory)
SELECT TicketCategory FROM TicketCategory


UPDATE a
SET NumberArrived = x.Arrived
FROM @TicketArrivedSummary a
INNER JOIN (
SELECT tc.TicketCategory, count(*) as Arrived
from [dbo].[TicketsIssued] t
LEFT JOIN dbo.TicketCategory tc on t.Category = tc.TicketCategoryCode
where [ArrivedAt] is not null
group by  tc.TicketCategory) x ON a.TicketCategory = x.TicketCategory


UPDATE a
SET NumberToArrive = x.NotArrived
FROM @TicketArrivedSummary a
INNER JOIN (
SELECT tc.TicketCategory, count(*) as NotArrived
from [dbo].[TicketsIssued] t
LEFT JOIN dbo.TicketCategory tc on t.Category = tc.TicketCategoryCode
where [ArrivedAt] is null
group by  tc.TicketCategory) x ON a.TicketCategory = x.TicketCategory

UPDATE a
SET TotalNumberOfTickets = a.NumberArrived + a.NumberToArrive
FROM @TicketArrivedSummary a

SELECT * FROM @TicketArrivedSummary

END