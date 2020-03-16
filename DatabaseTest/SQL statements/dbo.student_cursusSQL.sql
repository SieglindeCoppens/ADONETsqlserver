CREATE TABLE [dbo].[student_cursusSQL]
(
	[cursusId] INT NOT NULL, 
	[studentId]	INT	NOT NULL,
	PRIMARY KEY CLUSTERED ([cursusId] ASC, [studentId] ASC),
    CONSTRAINT[FK_student_cursus_cursusSQL] FOREIGN KEY ([cursusID]) REFERENCES [dbo].[cursusSQL] ([Id]),
	CONSTRAINT[FK_student_cursus_studentSQL] FOREIGN KEY ([studentID]) REFERENCES [dbo].[studentSQL] ([Id]),
);
