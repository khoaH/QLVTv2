USE [QLVT_DATHANG]
GO

/****** Object:  View [dbo].[V_DS_PHANMANH]    Script Date: 20/07/21 1:05:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_DS_PHANMANH]
AS
SELECT  TENCN=PUBS.description, TENSERVER= subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server

GO

