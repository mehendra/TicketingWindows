CREATE TABLE [dbo].[TicketStatus] (
    [TicketStatusCode] VARCHAR (4) NOT NULL,
    [TicketStatus]     NCHAR (50)  NULL,
    CONSTRAINT [PK_TicketStatus] PRIMARY KEY CLUSTERED ([TicketStatusCode] ASC)
);

