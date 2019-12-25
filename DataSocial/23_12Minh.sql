USE [DataSocial]
GO
/****** Object:  StoredProcedure [dbo].[GetMailboxlist]    Script Date: 12/23/2019 11:31:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[GetMailboxlist]
	@IDuser	varchar(30)
AS
BEGIN
	

	SELECT TEMP.IDmessengerbox,TEMP.NAME, dbo.PROFILE.AVATAR ,TEMP.UIDuser,MESSENGER.Content
	FROM  dbo.MESSENGER, dbo.PROFILE, 

			(SELECT MB.IDmessengerbox ,NAME,UIDuser,MB.LASTMODIFY
			FROM dbo.MessengerBox AS MB, dbo.PROFILE
			WHERE ((MB.IDuser1 = @IDuser AND dbo.PROFILE.UIDuser = MB.IDuser2)
			OR(MB.IDuser2 = @IDuser AND dbo.PROFILE.UIDuser = MB.IDuser1))
			) as TEMP

	WHERE TEMP.IDmessengerbox = dbo.MESSENGER.IDmessengerbox AND temp.UIDuser = dbo.PROFILE.UIDuser
			AND IDmessenger = (
							SELECT TOP 1 IDmessenger
							FROM dbo.MESSENGER
							WHERE TEMP.IDmessengerbox = dbo.MESSENGER.IDmessengerbox
							ORDER BY dbo.MESSENGER.TIME DESC
							)
	ORDER BY TEMP.LASTMODIFY
END

