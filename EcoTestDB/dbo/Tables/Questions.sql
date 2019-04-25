CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [QuestionId] INT NOT NULL, 
    [QuestionText] NVARCHAR(100) NOT NULL, 
    [FirstAnswer] NVARCHAR(50) NOT NULL, 
    [SecondAnswer] NVARCHAR(50) NOT NULL, 
    [ThirdAnswer] NVARCHAR(50) NOT NULL, 
    [RightAnswer] NVARCHAR(50) NOT NULL
)
