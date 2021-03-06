CREATE procedure [dbo].[SeachTicketsWithWildCards]
	@TicketNumber varchar(17) = null,
	@Category varchar(50) = null,
	@SoldBy varchar(10) = null,
	@SoldTo varchar(20) = null,
	@TableNo int = null,
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
	[SoldTo] [varchar](255) NULL,
	TableNumber int null
)
insert into @AllRecords( TicketId, [TicketNumber]
      ,[AgentCode]
      ,[Category]
      ,[TicketStatusCode]
      ,[ArrivedAt]
      ,[ArrivalConfirmedBy]
	  ,AgentName
	  ,[TicketStatus], Zone,SoldTo,TableNumber )
select t.TicketId, t.TicketNumber,t.AgentCode, tc.TicketCategory as Category,t.TicketStatusCode,t.ArrivedAt,t.ArrivalConfirmedBy,a.AgentName,ts.TicketStatus, t.Zone,T.SoldTo, T.TableNumber  from dbo.TicketsIssued t inner join dbo.Agent a
on t.AgentCode = a.AgentCode 
left join [dbo].[TicketStatus] ts on ts.TicketStatusCode = t.TicketStatusCode
left join dbo.TicketCategory tc on tc.TicketCategoryCode = t.Category
where a.AgentName like case when @SoldBy is null then a.AgentName  else '%' + @SoldBy + '%' end
and ISNULL(t.TicketNumber,'') like case when @TicketNumber is null then  ISNULL(t.TicketNumber,'') else '%' + @TicketNumber + '%' end
and ISNULL(t.SoldTo,'') like case when @SoldTo is null then  ISNULL(t.SoldTo,'') else '%' + @SoldTo + '%' end
and isnull(t.Category,'') = case when @Category is null then isnull(t.Category,'') else @Category end
and ISNULL(t.TableNumber,0) = case when @TableNo > 0 then @TableNo	else ISNULL(t.TableNumber,0) end

SELECT @RcordCount = count(*) from @allRecords

select @TotalRecords = @RcordCount

select * from @AllRecords
WHERE idx between (@RecordsPerPage * (@PagingStartIndex -1)) +1 and @RecordsPerPage * @PagingStartIndex
end
