CREATE TABLE [dbo].[TicketsIssued] (
    [TicketNumber]       VARCHAR (17)  NOT NULL,
    [AgentCode]          VARCHAR (4)   NOT NULL,
    [Category]           VARCHAR (50)  NULL,
    [TicketStatusCode]   VARCHAR (4)   NULL,
    [ArrivedAt]          DATETIME      NULL,
    [ArrivalConfirmedBy] VARCHAR (255) NULL,
    [Paid]               DATE          NULL,
    [Notes]              VARCHAR (500) NULL,
    [SoldTo]             VARCHAR (255) NULL,
    [Zone]               VARCHAR (10)  NULL,
    [TicketId]           INT           IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_TicketsIssued] PRIMARY KEY CLUSTERED ([TicketId] ASC),
    CONSTRAINT [fk_Agent] FOREIGN KEY ([AgentCode]) REFERENCES [dbo].[Agent] ([AgentCode]),
    CONSTRAINT [fk_TicketStatus] FOREIGN KEY ([TicketStatusCode]) REFERENCES [dbo].[TicketStatus] ([TicketStatusCode])
);



