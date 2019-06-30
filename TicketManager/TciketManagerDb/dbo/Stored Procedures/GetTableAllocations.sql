CREATE Procedure GetTableAllocations AS BEGIN
Select 
CASE 
	WHEN TableNumber IS NULL THEN 'UnAllocated'
	ELSE cast(TableNumber as varchar(10)) 
	end as TableNumber

,count(*) NumberOfPeople from [dbo].[TicketsIssued]
Where Category not in ('GEN', 'KID')
group by CASE 
	WHEN TableNumber IS NULL THEN 'UnAllocated'
	ELSE cast(TableNumber as varchar(10))
	end
END
GO
