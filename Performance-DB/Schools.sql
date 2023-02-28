CREATE TABLE Schools
([SchoolId] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (100),
[Address1] [nvarchar] (100),
[Address2] [nvarchar] (100),
[PostalZipCode] [varchar] (20),
[City] [nvarchar] (50),
[PhoneNumber] [nvarchar] (50),
) ON [PRIMARY]
CREATE NONCLUSTERED INDEX 
[NonClusteredIndex_Id_Name_ZipCode] ON dbo.schools 
([SchoolId], [Name], [PostalZipCode]) INCLUDE ([Address1], [Address2], [City], [PhoneNumber]) ON [PRIMARY]

GO
ALTER TABLE [Schools] ADD CONSTRAINT [PK_SchoolId] PRIMARY KEY CLUSTERED  ([SchoolId]) ON [PRIMARY]
GO