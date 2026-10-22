CREATE TABLE tGenre
(
ID int PRIMARY KEY IDENTITY,
Name nvarchar(100) NOT NULL UNIQUE,
[Description] nvarchar(MAX)
)

CREATE TABLE tShow
(
ID int PRIMARY KEY IDENTITY,
Name nvarchar(100) NOT NULL UNIQUE,
Genre int NOT NULL,
[Description] nvarchar(MAX)
)

CREATE TABLE tEpisode
(
ID int PRIMARY KEY IDENTITY,
Name nvarchar(100) NOT NULL UNIQUE,
Show int NOT NULL, -- FOREIGN KEY REFERENCES tGenre(ID),
Season int,
SeasonEpNum int,
[Description] nvarchar(MAX),
[VideoFilePath] nvarchar(MAX) NOT NULL,
[ImageFilePath] nvarchar(MAX),
RecentPlays int NOT NULL,
TotalPlays int NOT NULL
)


ALTER TABLE tEpisode
Add Foreign Key (Show)
References tShow(ID)

ALTER TABLE tEpisode
ADD UNIQUE(Name)