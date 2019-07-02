CREATE TABLE [dbo].[TicketSiteUser] (
    [UserId]   INT          IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (20) NOT NULL,
    [Password] VARCHAR (20) NOT NULL,
    [Role]     VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_TicketSiteUser] PRIMARY KEY CLUSTERED ([UserId] ASC)
);

