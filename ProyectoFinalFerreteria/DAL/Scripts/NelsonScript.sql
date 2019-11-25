create database Nelson

go

use Nelson

/*create view ClientesConDeudas as
	select Clienteid,Codigo,Nombres,Apellidos,LimiteCredito,Balance from Clientes where Balance > 0
	
create view ArticulosPocoInventario as
	select Articuloid,Codigo,Descripcion,Marca,PrecioUnitario,Inventario from Articulos where Inventario <=5

create view VentasDiarias as
	select Fecha,Facturaid,ITBIS,Descuentos,TotalGeneral from Facturas where Fecha = GETDATE();*/

	create view ImprimirFacturaReal as
	select a.Articuloid,a.Descripcion,a.Marca,a.Unidad,f.Cantidad, a.PrecioUnitario, (f.Cantidad*a.PrecioUnitario) as Importe
		   	,(select TotalGeneral from Facturas where Facturaid = f.Facturaid) as TotalGeneral,
			(select Comentarios from Facturas where Facturaid = f.Facturaid) as Comentarios,
			(select Nombres from Clientes) as [Nombre del Cliente],
			(select Apellidos from Clientes) as [Apellido del cliente],
			(select Balance from Clientes) as [Balance del cliente]
		from Articulos as a inner join FacturaDetalles as f on a.Articuloid = f.Articuloid


