create database ProyectoFinalDb

go 

use ProyectoFinalDb

create table Usuarios(

	Usuarioid int primary key identity,
	Nombre varchar(30),
	Contraseña varchar(20),
)

go

create table Clientes(

	Clienteid int primary key identity,
	Nombres varchar(50),
	Apellidos varchar(50),
	Cedula varchar(15),
	Direccion varchar(50),
	Telefono varchar(15),
	Celular varchar(15),
	Codigo varchar(8),
	LimiteCredito decimal,
	Email varchar(30),
	Balance decimal
)

go

create table Facturas(

	Facturaid int primary key identity,
	Clienteid int,
	TipoFactura varchar(30),
	Fecha date,
	SubTotal decimal,
	Descuentos decimal,
	ITBIS decimal,
	TotalGeneral decimal,
	CantidadArticulos int,
	Balance decimal
)

go

create table Articulos(

	Articuloid int primary key identity,
	Codigo varchar(30),
	Descripcion varchar(40),
	Marca varchar(30),
	PrecioUnitario decimal,
	Unidad varchar(30),
	Inventario int
)

go

create table FacturaDetalle(

	Detalleid int primary key identity,
	Facturaid int,
	Articuloid int,
	Cantidad int,
	constraint FK_FacturaDetalleArticulos foreign key (Articuloid) references Articulos(Articuloid)
	on delete cascade
	on update cascade,
	constraint FK_FacturaDetalleFactura foreign key (Facturaid) references Facturas(Facturaid)
	on delete cascade
	on update cascade
)


