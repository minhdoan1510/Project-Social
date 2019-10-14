USE master
GO
CREATE DATABASE DataSocial
GO

USE DataSocial
GO

CREATE TABLE ACCOUNT
(
    UID VARCHAR(30) NOT NULL,
    ID VARCHAR(20),
    PASS VARCHAR(20)
    CONSTRAINT PK_ACCOUNT PRIMARY KEY (ID)
)
CREATE TABLE PROFILE
(
    UIDuser VARCHAR(30) NOT NULL,
    NAME VARCHAR(20),
    AVATAR IMAGE DEFAULT NULL
    CONSTRAINT PK_PROFILE PRIMARY KEY (UIDuser)
)

ALTER TABLE dbo.ACCOUNT ADD CONSTRAINT FK_ACCOUNT FOREIGN KEY (UID) REFERENCES dbo.PROFILE(UIDuser)

--CSDSCSDCSDCSDC

CREATE TABLE FRIEND
(
	UID1 VARCHAR(30) NOT NULL,
	UID2 VARCHAR(30) NOT NULL
	CONSTRAINT FK_FRIEND1 FOREIGN KEY (UID1) REFERENCES dbo.PROFILE(UIDuser),
	CONSTRAINT FK_FRIEND2 FOREIGN KEY (UID2) REFERENCES dbo.PROFILE(UIDuser)
)

-- svsdvsdvsdv

CREATE TABLE POST
(
	IDPOST VARCHAR(30) PRIMARY KEY,
	IDUSER VARCHAR(30),
	LIKED INTEGER,
	CONTENT TEXT,
	IMAGE IMAGE DEFAULT NULL,
	TIME DATETIME DEFAULT GETDATE()
	CONSTRAINT FK_POST FOREIGN KEY (IDUSER) REFERENCES dbo.PROFILE(UIDuser)
)

CREATE TABLE COMMENT
(
	IDcomment VARCHAR(30) PRIMARY KEY,
	IDPOST VARCHAR(30),
	CONTENT TEXT,
	TIME DATETIME DEFAULT GETDATE()
	CONSTRAINT FK_COMMENT FOREIGN KEY (IDPOST) REFERENCES dbo.POST(IDPOST)
)

--MESSENGER

CREATE TABLE MessengerBox
(
	IDmessengerbox VARCHAR(30) PRIMARY KEY
)

CREATE TABLE MESSENGER
(
	IDmessenger VARCHAR(30)PRIMARY KEY,
	IDmessengerbox VARCHAR(30),
	UIDsend VARCHAR(30) NOT NULL,
	Content TEXT,
	Image IMAGE DEFAULT NULL,
	TIME DATETIME DEFAULT GETDATE()
	CONSTRAINT FK_MESSENGER_MessengerBox FOREIGN KEY (IDmessengerbox) REFERENCES dbo.MessengerBox(IDmessengerbox),
	CONSTRAINT FK_MESSENGER_PROFILE FOREIGN KEY (UIDsend) REFERENCES dbo.PROFILE(UIDuser)

)


USE DataSocial
GO

SELECT *
FROM dbo.ACCOUNT
WHERE ID = 'nkoxway49' AND PASS = '123';


SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
FROM dbo.POST AS Post, dbo.PROFILE AS Profile
WHERE  Post.IDUSER = '99841234' AND Post.IDUSER=Profile.UIDuser
UNION ALL
SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
FROM dbo.POST AS Post
INNER JOIN dbo.FRIEND AS Friend  ON (Friend.UID1 = '99841234'AND Friend.UID2 = Post.IDUSER)OR(Friend.UID2 = '99841234'AND Friend.UID1 = Post.IDUSER)
INNER JOIN dbo.PROFILE AS Profile on Post.IDUSER=Profile.UIDuser



ALTER TABLE dbo.FRIEND DROP CONSTRAINT FK_FRIEND1,FK_FRIEND2

SELECT *
FROM dbo.ACCOUNT
WHERE ID = 'nkoxway49' AND PASS = '123';


 

 INSERT dbo.POST
(
    IDPOST,
    IDUSER,
    LIKED,
    CONTENT,
    IMAGE,
    TIME
)
VALUES
(   '23423443',       -- IDPOST - varchar(30)
    '32940241',       -- IDUSER - varchar(30)
    50,        -- LIKED - int
    'Đạt đăng',       -- CONTENT - text
    NULL,     -- IMAGE - image
    GETDATE() -- TIME - datetime
)
INSERT dbo.POST
(
    IDPOST,
    IDUSER,
    LIKED,
    CONTENT,
    IMAGE,
    TIME
)
VALUES
(   '23422443',       -- IDPOST - varchar(30)
    '77182930',       -- IDUSER - varchar(30)
    50,        -- LIKED - int
    'Non k biet',       -- CONTENT - text
    NULL,     -- IMAGE - image
    GETDATE() -- TIME - datetime
)
INSERT dbo.POST
(
    IDPOST,
    IDUSER,
    LIKED,
    CONTENT,
    IMAGE,
    TIME
)
VALUES
(   '22114223',       -- IDPOST - varchar(30)
    '33755086',       -- IDUSER - varchar(30)
    50,        -- LIKED - int
    'huy đăng',       -- CONTENT - text
    NULL,     -- IMAGE - image
    GETDATE() -- TIME - datetime
)
INSERT dbo.POST
(
    IDPOST,
    IDUSER,
    LIKED,
    CONTENT,
    IMAGE,
    TIME
)
VALUES
(   '23444043',       -- IDPOST - varchar(30)
    '80267710',       -- IDUSER - varchar(30)
    50,        -- LIKED - int
    'Long Đăng',       -- CONTENT - text
    NULL,     -- IMAGE - image
    GETDATE() -- TIME - datetime
)
INSERT dbo.POST
(
    IDPOST,
    IDUSER,
    LIKED,
    CONTENT,
    IMAGE,
    TIME
)
VALUES
(   '99555234',       -- IDPOST - varchar(30)
    '99841234',       -- IDUSER - varchar(30)
    50,        -- LIKED - int
    'Minh admin đăng',       -- CONTENT - text
    NULL,     -- IMAGE - image
    GETDATE() -- TIME - datetime
)


ALTER TABLE dbo.FRIEND ADD CONSTRAINT FK_FRIEND1 FOREIGN KEY (UID1) REFERENCES dbo.PROFILE(UIDuser)
ALTER TABLE dbo.FRIEND ADD CONSTRAINT FK_FRIEND2 FOREIGN KEY (UID2) REFERENCES dbo.PROFILE(UIDuser)

INSERT dbo.FRIEND
(
    UID1,
    UID2
)
VALUES
(   '99841234', -- UID1 - varchar(30)
    '80267710'  -- UID2 - varchar(30)
)

INSERT dbo.FRIEND
(
    UID1,
    UID2
)
VALUES
(   '77182930', -- UID1 - varchar(30)
    '80267710'  -- UID2 - varchar(30)
)

ALTER TABLE dbo.COMMENT ADD IDuser VARCHAR(30)
ALTER TABLE dbo.COMMENT ADD CONSTRAINT FK_Comment_user FOREIGN KEY (IDuser) REFERENCES dbo.PROFILE (UIDuser)

INSERT dbo.COMMENT
(
    IDcomment,
    IDPOST,
    CONTENT,
    TIME,
    IDuser
)
VALUES
(   '23511111',        -- IDcomment - varchar(30)
    '22114223',        -- IDPOST - varchar(30)
    'Minh Đoàn đăng thử',        -- CONTENT - text
    GETDATE(), -- TIME - datetime
    '32940241'         -- IDuser - varchar(30)
    )



	INSERT dbo.COMMENT
(
    IDcomment,
    IDPOST,
    CONTENT,
    TIME,
    IDuser
)
VALUES
(   '23515511',        -- IDcomment - varchar(30)
    '22114223',        -- IDPOST - varchar(30)
    'tesccc đăng thử',        -- CONTENT - text
    GETDATE(), -- TIME - datetime
    '77182930'         -- IDuser - varchar(30)
    )
	
	
	INSERT dbo.COMMENT
(
    IDcomment,
    IDPOST,
    CONTENT,
    TIME,
    IDuser
)
VALUES
(   '23511111',        -- IDcomment - varchar(30)
    '22114223',        -- IDPOST - varchar(30)
    'Minh Đoàn đăng thử',        -- CONTENT - text
    GETDATE(), -- TIME - datetime
    '32940241'         -- IDuser - varchar(30)
    )
	
	
	INSERT dbo.COMMENT
(
    IDcomment,
    IDPOST,
    CONTENT,
    TIME,
    IDuser
)
VALUES
(   '23511111',        -- IDcomment - varchar(30)
    '22114223',        -- IDPOST - varchar(30)
    'Minh Đoàn đăng thử',        -- CONTENT - text
    GETDATE(), -- TIME - datetime
    '32940241'         -- IDuser - varchar(30)
    )


SELECT Profile.UIDuser, Profile.NAME,Profile.AVATAR, Post.IDPOST, CMT.IDcomment, CMT.CONTENT,CMT.TIME
FROM dbo.COMMENT AS CMT
INNER JOIN dbo.PROFILE AS Profile ON Profile.UIDuser = CMT.IDuser
INNER JOIN dbo.POST AS Post ON Post.IDPOST = CMT.IDPOST
WHERE CMT.IDPOST='22114223'


INSERT dbo.COMMENT
(
    IDcomment,
    IDPOST,
    CONTENT,
    TIME,
    IDuser
)
VALUES
(   '61526816',        -- IDcomment - varchar(30)
    '22114223',        -- IDPOST - varchar(30)
    'Minh nhưỡng',        -- CONTENT - text
    GETDATE(), -- TIME - datetime
    '32940241'         -- IDuser - varchar(30)
    )

SELECT * FROM
                dbo.ACCOUNT
                WHERE ID = 'nkoxway49' AND PASS = '123'



SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
FROM dbo.POST AS Post, dbo.PROFILE AS Profile
WHERE  Post.IDUSER = '99841234' AND Post.IDUSER=Profile.UIDuser
UNION ALL
SELECT Post.IDUSER,Post.IDPOST,Post.LIKED,Post.CONTENT,Post.IMAGE,Post.TIME, Profile.NAME
FROM dbo.POST AS Post
INNER JOIN dbo.FRIEND AS Friend  ON (Friend.UID1 = '99841234'AND Friend.UID2 = Post.IDUSER)OR(Friend.UID2 = '99841234'AND Friend.UID1 = Post.IDUSER)
INNER JOIN dbo.PROFILE AS Profile on Post.IDUSER=Profile.UIDuser

TRUNCATE TABLE dbo.COMMENT

ALTER TABLE dbo.PROFILE ALTER COLUMN NAME NVARCHAR(30)