create database [Logs]
go

use [Logs]
go

create table [dbo].[Logs](
	[LogId] [int] IDENTITY(1,1) not null,
	[Level] [varchar](max) not null,
	[CallSite] [varchar](max) not null,
	[Type] [varchar](max) not null,
	[ErrorType] [varchar](max) not null,
	[Message] [varchar](max) not null,
	[StackTrace] [varchar](max) not null,
	[InnerException] [varchar](max) not null,
	[CustomInfo] [varchar](max) not null,
	[LoggedOnDate] [datetime] not null constraint [df_logs_loggedondate]  default (getutcdate()),

	constraint [pk_logs] primary key clustered 
	(
		[LogId]
	)
)
go
    
create procedure InsertLog
(
	@logLevel varchar(max),
	@CallSite varchar(max),
	@Type varchar(max),
	@ErrorType varchar(max),
	@Message varchar(max),
	@StackTrace varchar(max),
	@InnerException varchar(max),
	@CustomInfo varchar(max)	
)
as
insert into dbo.Logs
(
	[Level],
	[CallSite],
	[Type],
	[ErrorType],
	[Message],
	[StackTrace],
	[InnerException],
	[CustomInfo]	
)
values
(
	@logLevel,
	@CallSite,
	@Type,
	@ErrorType,
	@Message,
	@StackTrace,
	@InnerException,
	@CustomInfo	
)
go