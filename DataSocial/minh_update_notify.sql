CREATE TABLE NOTIFY
(
	IDnotify  VARCHAR(30),
	IDPost VARCHAR(30),
	Content NTEXT,
	Time DATETIME DEFAULT GETDATE(),
	IDuserSend VARCHAR(30),
	TypeNotify SMALLINT NOT NULL

	CONSTRAINT PK_NOTIFY PRIMARY KEY (IDnotify),
	CONSTRAINT FK_IDPost FOREIGN KEY (IDPost) REFERENCES dbo.POST(IDPOST)
)

CREATE TABLE PEOPLE_FOLLOW_POST
(
	IDPost  VARCHAR(30),
	IDuser VARCHAR(30)
	CONSTRAINT PK_PEOPLE_NOTIFY PRIMARY KEY (IDPost,IDuser),
	CONSTRAINT FK_IDPost_POST FOREIGN KEY (IDPost) REFERENCES dbo.POST(IDPost),
	CONSTRAINT FK_IDuser_PROFILE FOREIGN KEY (IDuser) REFERENCES dbo.PROFILE(UIDuser)
)

CREATE TRIGGER POST_Insert_PEOPLE_FOLLOW__POST
ON POST
FOR INSERT
AS 
	BEGIN
		DECLARE @IDPost varchar(30);
		DECLARE @IDuser varchar(30);

		SELECT @IDuser = inserted.IDPost, @IDuser = inserted.IDUser
		FROM inserted

		
		INSERT dbo.PEOPLE_FOLLOW_POST
		(
		    IDPost,
		    IDuser
		)
		VALUES
		(   @IDPost, -- IDPost - varchar(30)
		    @IDuser  -- IDuser - varchar(30)
		)
		
    END
    

CREATE PROC AddNotify
	@IDNotify varChar(30),
	@IDPost VARCHAR(30),
	@Content NTEXT,
	@IDuser VARCHAR(30),
	@TypeNotify SMALLINT
AS
	BEGIN
		INSERT dbo.NOTIFY
		(
		    IDnotify,
		    IDPost,
		    Content,
		    Time,
			TypeNotify
		)
		VALUES
		(   @IDNotify,       -- IDnotify - varchar(30)
		    @IDPost,       -- IDPost - varchar(30)
		    @Content,      -- Content - ntext
		    GETDATE(),	-- Time - datetime
			@TypeNotify
		)

		IF (0=(
			   SELECT COUNT(*)
			   FROM dbo.PEOPLE_FOLLOW_POST
			   WHERE dbo.PEOPLE_FOLLOW_POST.IDuser = @IDuser AND dbo.PEOPLE_FOLLOW_POST.IDPost = @IDPost
			  ))
			INSERT dbo.PEOPLE_FOLLOW_POST
			(
			    IDPost,
			    IDuser
			)
			VALUES
			(   @IDPost, -- IDnotify - varchar(30)
			    @IDUser  -- IDuser - varchar(30)
			)

    END
    

CREATE PROC GetAllNotifyofUser
	@IDuser VARCHAR(30)
AS
	BEGIN
		SELECT dbo.NOTIFY.IDnotify, dbo.NOTIFY.IDPost,dbo.NOTIFY.Content,Nggui.NAME, NgNhan.NAME, NgNhan.UIDuser
		FROM dbo.NOTIFY, dbo.PROFILE AS Nggui, dbo.POST, dbo.PROFILE AS NgNhan
		WHERE  dbo.NOTIFY.IDPost IN(SELECT dbo.PEOPLE_FOLLOW_POST.IDPost
										FROM dbo.PEOPLE_FOLLOW_POST
										where dbo.PEOPLE_FOLLOW_POST.IDuser = @IDuser)
			   AND @IDuser != IDuserSend
			   AND Nggui.UIDuser = @IDuser
			   AND dbo.POST.IDPOST = dbo.NOTIFY.IDPost
			   AND dbo.POST.IDUSER = NgNhan.UIDuser
		ORDER BY dbo.NOTIFY.Time DESC
	END

CREATE PROC GetOnlyOneNotify
	@IDNotify varchar(30),
	@IDuser VARCHAR(30)
AS
	BEGIN
		SELECT dbo.NOTIFY.IDnotify, dbo.NOTIFY.IDPost,dbo.NOTIFY.Content,Nggui.NAME, NgNhan.NAME, NgNhan.UIDuser
		FROM dbo.NOTIFY, dbo.PROFILE AS Nggui, dbo.POST, dbo.PROFILE AS NgNhan
		WHERE  dbo.NOTIFY.IDnotify = @IDNotify
			   AND Nggui.UIDuser = @IDuser
			   AND dbo.POST.IDPOST = dbo.NOTIFY.IDPost
			   AND dbo.POST.IDUSER = NgNhan.UIDuser
	END

CREATE PROC GetListSendNotify
	@IDNotify varchar(30)
AS
	BEGIN
		SELECT DISTINCT dbo.PEOPLE_FOLLOW_POST.IDuser
		FROM dbo.NOTIFY,dbo.PEOPLE_FOLLOW_POST
		WHERE dbo.NOTIFY.IDnotify = @IDNotify 
			  AND dbo.NOTIFY.IDPost = dbo.PEOPLE_FOLLOW_POST.IDPost
	END