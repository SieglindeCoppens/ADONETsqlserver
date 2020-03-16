CREATE TABLE [dbo].[studentSQL]
(
	[Id] INT IDENTITY(1,1) NOT NULL, 
    [naam] NVARCHAR(50) NULL,
	[klasId] INT	NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC),
	CONsTRAINT[FK_student_klasSQL] FOREIGN KEY ([klasID]) REFERENCES [dbo].[klasSQL] ([Id])
);
