CREATE TABLE BugTable
(
	UIDuser VARCHAR(30),
	CONTENT Ntext

	CONSTRAINT FK_BugTable FOREIGN KEY (UIDuser) REFERENCES dbo.PROFILE(UIDuser)
)

CREATE PROC AddBugTable
	@UIDuser VARCHAR(30),
	@CONTENT Ntext
AS
	BEGIN
		INSERT dbo.BugTable
		(
		    UIDuser,
		    CONTENT
		)
		VALUES
		(   @UIDuser, -- UIDuser - varchar(30)
		    @CONTENT -- CONTENT - ntext
		)
	END