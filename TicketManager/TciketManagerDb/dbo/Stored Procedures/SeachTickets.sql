create procedure [dbo].[SeachTickets]
	@TicketNumber varchar(17) = null,
	@AgentCode varchar(10) = null,
	@TicketStatusCode varchar(4) = null,
	@Category varchar(50) = null,
	@RcordCount int = 0,
	@RecordsPerPage int = 0,
	@PagingStartIndex int = 1,
	@TotalRecords int out
as begin

--test data
--set @AgentCode = 'CHA'
--set @TicketNumber = '8'
--set @RecordsPerPage = 40

declare @AllRecords as table
(
	[idx] int not null identity (1,1),
	TicketId int not null,
	[TicketNumber] [varchar](17) NOT NULL,
	[AgentCode] [varchar](10) NULL,
	[Category] [varchar](50) NULL,
	[TicketStatusCode] [varchar](4) NULL,
	[ArrivedAt] [datetime] NULL,
	[ArrivalConfirmedBy] [varchar](255) NULL,
	[AgentName] [varchar](255) NULL,
	[TicketStatus] nvarchar(50) null,
	[Zone] varchar(10) null,
	[SoldTo] [varchar](255) NULL
)
insert into @AllRecords( TicketId, [TicketNumber]
      ,[AgentCode]
      ,[Category]
      ,[TicketStatusCode]
      ,[ArrivedAt]
      ,[ArrivalConfirmedBy]
	  ,AgentName
	  ,[TicketStatus], Zone,SoldTo )
select t.TicketId, t.TicketNumber,t.AgentCode, t.Category,t.TicketStatusCode,t.ArrivedAt,t.ArrivalConfirmedBy,a.AgentName,ts.TicketStatus, t.Zone,T.SoldTo  from dbo.TicketsIssued t inner join dbo.Agent a
on t.AgentCode = a.AgentCode left join [dbo].[TicketStatus] ts
on ts.TicketStatusCode = t.TicketStatusCode
where t.AgentCode = case when @AgentCode is null then t.AgentCode else @AgentCode  end
and t.TicketNumber like case when @TicketNumber is null then t.TicketNumber else @TicketNumber + '%' end
and isnull(t.TicketStatusCode,'') = case when @TicketStatusCode is null then isnull(t.TicketStatusCode,'') else @TicketStatusCode end
and isnull(t.Category,'') = case when @Category is null then isnull(t.Category,'') else @Category end


SELECT @RcordCount = count(*) from @allRecords

select @TotalRecords = @RcordCount

select * from @AllRecords
WHERE idx between (@RecordsPerPage * (@PagingStartIndex -1)) +1 and @RecordsPerPage * @PagingStartIndex
end