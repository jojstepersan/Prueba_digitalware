create table Productos(
IdProducto int not null identity,
Nombre nvarchar(max) null,
Descripcion nvarchar(max) null,
Precio decimal(18,2) not null,
constraint PK_Producto primary key(IdProducto)
);
go
create table Inventario(
IdProducto int not null,
CantidadExistente decimal(18,2) not null,
constraint FK_Inventario_Producto foreign key(IdProducto) references productos(IdProducto)
);
go
CREATE TABLE [TipoIdentificacions] (
    [TipoIdentificacionId] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NULL,
    [Descripcion] nvarchar(max) NULL,
    CONSTRAINT [PK_TipoIdentificacions] PRIMARY KEY ([TipoIdentificacionId])
); go
CREATE TABLE [Personas] (
    [PersonaId] int NOT NULL IDENTITY,
    [Nombres] nvarchar(max) NULL,
    [FechaNacimiento] datetime2 NOT NULL,
    [Identificacion] nvarchar(max) NULL,
    [TipoIdentificacionId] int NOT NULL,
    CONSTRAINT [PK_Personas] PRIMARY KEY ([PersonaId]),
    CONSTRAINT [FK_Personas_TipoIdentificacions_TipoIdentificacionId] FOREIGN KEY ([TipoIdentificacionId]) REFERENCES [TipoIdentificacions] ([TipoIdentificacionId]) ON DELETE CASCADE
);go
CREATE TABLE [Clientes] (
    [ClienteId] int NOT NULL IDENTITY,
    [PersonaId] int NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([ClienteId]),
    CONSTRAINT [FK_Clientes_Personas_PersonaId] FOREIGN KEY ([PersonaId]) REFERENCES [Personas] ([PersonaId]) ON DELETE CASCADE
);
GO
CREATE TABLE [Venta] (
    [VentaId] int NOT NULL IDENTITY,
    [Fecha] datetime2 NOT NULL,
    [ClienteId] int NOT NULL,
    [EmpleadoId] int NOT NULL,
    [Total] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Venta] PRIMARY KEY ([VentaId])
);
GO
CREATE TABLE [Ordenes] (
    [VentaId] int NOT NULL,
    [IdProducto] int NOT NULL,
	[CantidadVendida] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Ordenes] PRIMARY KEY ([VentaId], [IdProducto]),
    CONSTRAINT [FK_Ordenes_Productos_ProductoId] FOREIGN KEY ([IdProducto]) REFERENCES [Productos] ([IdProducto]) ON DELETE CASCADE,
    CONSTRAINT [FK_Ordenes_Venta_VentaId] FOREIGN KEY ([VentaId]) REFERENCES [Venta] ([VentaId]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Bodegas_ProductoId] ON [inventario] ([IdProducto]);
GO


CREATE UNIQUE INDEX [IX_Clientes_PersonaId] ON [Clientes] ([PersonaId]);
GO

CREATE INDEX [IX_Ordenes_ProductoId] ON [Ordenes] ([IdProducto]);
GO


CREATE UNIQUE INDEX [IX_Personas_TipoIdentificacionId] ON [Personas] ([TipoIdentificacionId]);
GO


INSERT INTO TipoIdentificacions VALUES
('CC', 'Cedula Ciudadania')
, ('PS', 'Pasaporte');
GO

INSERT INTO Productos (Nombre,Precio)VALUES
('Producto 1', 10000)
, ('Producto 2', 11000)
, ('Producto 3', 12000)
, ('Producto 4', 13000)
, ('Producto 5', 14000)
, ('Producto 6', 15000)
, ('Producto 7', 16000)
, ('Producto 8', 17000);

GO

INSERT INTO Inventario values
(1,30)
, (1,50)
, (2,90)
, (3,110)
, (4,220)
, (5,30)
, (6,60)
, (7,70)
, (8,340);


select * from Productos;
