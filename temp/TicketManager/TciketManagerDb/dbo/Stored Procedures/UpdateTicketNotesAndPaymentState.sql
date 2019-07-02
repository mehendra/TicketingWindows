CREATE procedure [dbo].[UpdateTicketNotesAndPaymentState]
	@TicketId int,
	@TicketStatusCode varchar(4),
	@Notes varchar(500) null
as begin


UPDATE [dbo].[TicketsIssued]
SET [TicketStatusCode] = @TicketStatusCode,
Notes = @Notes
WHERE TicketId = @TicketId

END