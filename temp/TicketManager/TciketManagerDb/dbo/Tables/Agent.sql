CREATE TABLE [dbo].[Agent] (
    [AgentCode] VARCHAR (4)   NOT NULL,
    [AgentName] VARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Agent] PRIMARY KEY CLUSTERED ([AgentCode] ASC)
);

