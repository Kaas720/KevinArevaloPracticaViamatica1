
USE [prueba]
/*Tabla persona*/
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](200) NULL,
	[Apellidos] [varchar](200) NULL,
	[Correo] [varchar](200) NULL,
	[Direccion] [varchar](200) NULL,
	[estado] [varchar] (2)NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


/*Tabla usuario*/
CREATE TABLE [dbo].[Usuario](
	[idPersona] [int] NOT NULL,
	[idUsuaio] [int]  IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](200) NULL,
	[Clave] [varchar](200) NULL,
	[Estado] [varchar](2) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuaio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Persona] FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])


ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Persona]


/*Insert Datos*/

INSERT INTO prueba.dbo.Persona
(Nombres, Apellidos, Correo, Direccion, estado)
VALUES('Jeol', 'Arevalo', 'kevin@7520.com', 'Coop U bananero', 'A');


INSERT INTO prueba.dbo.Usuario
(idPersona, Usuario, Clave, Estado)
VALUES(1, 'jyyy', '0520', 'A');


SELECT *from Persona

SELECT *from Usuario

DELETE FROM prueba.dbo.Usuario 
WHERE idUsuaio=1;


