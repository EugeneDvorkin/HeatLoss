create procedure InsertLog
(
	@logLevel varchar(max),
	@exception varchar(max),
	@message varchar(max),
	@stacktrace varchar(max),
	@type varchar(max)
)
as

insert into dbo.Logs
(
	[LogLevel],
	[Exception],
	[Message],
	[Stacktrace],
	[Type]	
)
values
(
	@logLevel,
	@exception,
	@message,
	@stacktrace,
	@type	
)

go
      
     
      
      