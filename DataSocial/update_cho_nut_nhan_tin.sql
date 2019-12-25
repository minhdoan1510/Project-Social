USE [DataSocial]
GO
/****** Object:  StoredProcedure [dbo].[AddMess]    Script Date: 12/18/2019 10:43:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[AddMess]
	@IDmessbox varchar(30),
	@IDmess varchar(30),
	@UIDsend varchar(30),
	@Content  NTEXT

AS
BEGIN

	INSERT dbo.MESSENGER
	(
	    IDmessenger,
	    IDmessengerbox,
	    UIDsend,
	    Content,

	    TIME
	)
	VALUES
	(
		@IDmess,
		@IDmessbox,
		@UIDsend,
		@Content,
		GETDATE() -- TIME - datetime
	)

END

CREATE PROC GetIdMessbox
	@IdUser1 VARCHAR(30),
	@IdUser2 VARCHAR(30)
AS 
	BEGIN
	SELECT IDmessengerbox FROM dbo.MessengerBox WHERE (IDuser1 = @IdUser1 AND IDuser2 = @IdUser2) OR (IDuser1 = @IdUser2 AND IDuser2 = @IdUser1)
    END
    
CREATE PROC AddMessbox
	@IdMessbox VARCHAR(30),
	@IdUser1 VARCHAR(30),
	@IdUser2 VARCHAR(30)
AS 
	BEGIN
	INSERT INTO dbo.MessengerBox
	(
	    IDmessengerbox,
	    IDuser1,
	    IDuser2,
	    LASTMODIFY
	)
	VALUES
	(   @IDmessbox,                   -- IDmessengerbox - varchar(30)
	    @IdUser1,                   -- IDuser1 - varchar(30)
	    @IdUser2,                   -- IDuser2 - varchar(30)
	    GETDATE() -- LASTMODIFY - smalldatetime
	    )

    END
