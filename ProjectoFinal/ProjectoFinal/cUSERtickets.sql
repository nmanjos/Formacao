USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [tickets]    Script Date: 04/05/2017 16:31:38 ******/
CREATE LOGIN [tickets] WITH PASSWORD=N'gsxR/lcNfujO0YNlXuJYvAIaSf2079W1/uabn5Qo+/4=', DEFAULT_DATABASE=[TICKETS], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

ALTER LOGIN [tickets] DISABLE
GO

ALTER SERVER ROLE [sysadmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [securityadmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [serveradmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [setupadmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [processadmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [diskadmin] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [dbcreator] ADD MEMBER [tickets]
GO

ALTER SERVER ROLE [bulkadmin] ADD MEMBER [tickets]
GO

