Create table Students
(
StudentId int not null identity(1,1),
[FirstName] [nvarchar] (100),
[LastName] [nvarchar] (100),
[Address1] [nvarchar] (100),
[Address2] [nvarchar] (100),
[PostalZipCode] [varchar] (20),
[City] [nvarchar] (50),
[PhoneNumber] [nvarchar] (50),
[SchoolID] [int] Not NUll,
) ON [PRIMARY]
GO
ALTER TABLE [Students] ADD CONSTRAINT [PK_StudentId] PRIMARY KEY CLUSTERED  ([StudentId]) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX 
[NonClusteredIndex_Id_Name_ZipCode] ON dbo.students
( [FirstName], [PostalZipCode]) INCLUDE ([Address1], [Address2], [City], [PhoneNumber]) ON [PRIMARY]

GO
ALTER TABLE [Students] ADD CONSTRAINT [FK_SchoolId] FOREIGN KEY  ([SchoolId]) REFERENCES  [dbo].[SCHOOLS] ([SchoolId])
GO

