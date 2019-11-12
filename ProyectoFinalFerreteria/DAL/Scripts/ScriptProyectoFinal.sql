create database FerreteriaDb 

go

use FerreteriaDb

create table Cliente(

	ClienteId int primary key identity,
	Nombre varchar(30),
	Apellido varchar(30),
	Codigo char(5),
	Cedula varchar(13),
	Direccion varchar(50),
	Telefono varchar(15),
	Celular varchar(15),
	Balance decimal,
	limiteCredito decimal
)

create table Articulo(

	ArticuloId int primary key identity,
	Codigo char(5),
	Descripcion varchar(30),
	Marca varchar(20),
	PrecioUnitario decimal,
)

create table Factura(

	FacturaId int primary key identity,
	ClienteId int,
	TipoFactura varchar(30),
	Fecha date,
	SubTotal decimal,
	Descuentos decimal,
	ITBIS decimal,
	TotalGeneral decimal,
	CantidadArticulos int,
	NombreCliente varchar(30),
	DireccionCliente varchar(30),
	TelefonoCliente varchar(15),
	constraint FK_ClienteFactura foreign key (ClienteId) references Cliente(ClienteId)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)

create table DetalleArticulos(

	Id int primary key identity,
	FacturaId int,
	ArticuloId int,
	Descripcion varchar(50),
	Cantidad decimal,
	Unidad varchar(30),
	PrecioUnitario decimal,
	Importe decimal,
	constraint FK_FacturaArticulos foreign key (FacturaID) references Factura(FacturaId),
)

