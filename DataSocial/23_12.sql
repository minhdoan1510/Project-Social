 CREATE PROC SignIn
	@UserId VARCHAR(30),
	@PassWord VARCHAR(30)
AS
	BEGIN
 SELECT Profile.*
                FROM dbo.ACCOUNT AS acc, dbo.PROFILE AS Profile 
                WHERE acc.ID = @UserId AND acc.PASS = @PassWord AND Profile.UIDuser = acc.UID
	End
	
ALTER proc [dbo].[AddComment]
    @IDcomment VARCHAR(30),
	@IDPOST varchar(30),
	@CONTENT text, 
	@IDuser varchar(30)
AS
BEGIN
INSERT dbo.COMMENT
                                                            (
                                                                IDcomment,
                                                                IDPOST,
                                                                CONTENT,
                                                                TIME,
                                                                IDuser
                                                            )
                                                            VALUES
                                                            (   @IDcomment,        -- IDcomment - varchar(30)
                                                                @IDPOST,        -- IDPOST - varchar(30)
                                                                @CONTENT,        -- CONTENT - text
                                                                GETDATE(), -- TIME - datetime
                                                                @IDuser         -- IDuser - varchar(30)
                                                            )
END