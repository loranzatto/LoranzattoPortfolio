CREATE TABLE [dbo].[UsuarioOpiniao]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdUsuario] INT NOT NULL, 
    [Opiniao] NCHAR(1000) NOT NULL, 
    CONSTRAINT [FK_UsuarioOpiniao_Usuario] FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)
)
