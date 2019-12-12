
CREATE table  dbo.posts_like_list
(
	IdPost VARCHAR(30) NOT NULL ,
	IdUser VARCHAR(30) NOT NULL,
	CONSTRAINT PK_POST_USER PRIMARY KEY (IdPost,IdUser),
	CONSTRAINT FK_POST_LIKE FOREIGN KEY (IdPost) REFERENCES dbo.POST(IDPOST),
	CONSTRAINT FK_USER_LIKE FOREIGN KEY (IdUser) REFERENCES dbo.PROFILE(UIDuser)
)

CREATE TRIGGER USER_LIKE_INSERT_posts_like_list
ON dbo.posts_like_list
FOR INSERT
AS 
	BEGIN	
	UPDATE dbo.POST 
	SET LIKED = (          SELECT COUNT(*)
							FROM dbo.posts_like_list,inserted 
							WHERE inserted.IdPost = dbo.posts_like_list.IdPost)
	FROM inserted
	WHERE POST.IDPOST = inserted.IdPost
	END
   

CREATE TRIGGER USER_LIKE_DELETE_posts_like_list
ON dbo.posts_like_list
FOR delete
AS 
	BEGIN	
	DECLARE @IdPost VARCHAR(30)
	SELECT @IdPost = IDPOST FROM deleted
	UPDATE dbo.POST 
	SET LIKED = (          SELECT COUNT(*)
							FROM dbo.posts_like_list
							WHERE dbo.posts_like_list.IdPost = @IdPost)
	WHERE POST.IDPOST = @IdPost
	END