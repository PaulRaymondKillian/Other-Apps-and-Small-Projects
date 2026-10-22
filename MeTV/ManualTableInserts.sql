--Insert into tGenre(Name)
--values ('SciFi')

--Insert into tShow (Name, Genre)
--values ('Dexter', 3)

Insert into tEpisode (Name, Show, Season, SeasonEpNum, VideoFilePath, ImageFilePath)
values('Simpsons3', 1, 1, 3, 'C:\Simpsons3.avi', 'C:\Simpsons3.jpg')

--DELETE FROM tGenre
--WHERE Name in (select Name from tGenre)

select * from tEpisode
select * from tShow
select * from tGenre