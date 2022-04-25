Create database MuebleriaMultimedia;

use MuebleriaMultimedia
go

create table Categoria
(
    idCategoria int identity
        constraint Categoria_pk
            primary key,
    nombre      varchar(20) not null
)
go

create unique index Categoria_id_uindex
    on Categoria (idCategoria)
go

create table Material
(
    idMaterial int identity
        constraint Material_pk
            primary key,
    nombre     varchar(20) not null
)
go

create unique index Material_idMaterial_uindex
    on Material (idMaterial)
go

create table TipoMueble
(
    idMueble int identity
        constraint TipoMueble_pk
            primary key,
    nombre   varchar(20) not null
)
go

create table Mueble
(
    idMueble        int identity
        constraint Mueble_pk
            primary key,
    color           varchar(10) not null,
    precio          money       not null,
    cuidados        varchar(50) not null,
    imagen          image,
    fk_idTipoMueble int
        constraint fk_idTipoMueble
            references TipoMueble,
    fk_idCategoria  int
        constraint fk_idCategoria
            references Categoria,
    fk_idMaterial   int
        constraint fk_idMaterial
            references Material
)
go

create table Inventario
(
    fk_idMueble int
        constraint fk_idMueble
            references Mueble,
    stock       int not null
)
go

CREATE TABLE Facturacion(
	idFactura int identity
        constraint factura_pk primary key,
	nombreCliente varchar(25) default ('Anonimo'),
	apellidoCliente varchar(25) default ('Anonimo'),
)
go

create table Compra
(
    idCompra int identity
        constraint compra_pk primary key,
    fk_factura int
        constraint fk_idFactura
            references Facturacion,
    fk_idMuebleCompra int
        constraint fk_idMuebleCompra
            references Mueble,
    cantidad int not null,
    costo money not null
)
go

CREATE PROCEDURE Prueba @pIdFactura int--, @pIdMueble int, @pCantidad int
AS
BEGIN
	INSERT INTO Compra(fk_factura, fk_idMuebleCompra, cantidad, costo) VALUES (5, 1, 2,
    (SELECT (precio*2) FROM Mueble WHERE idMueble = 1))
    UPDATE Inventario SET stock = (SELECT (stock - 2) FROM Inventario WHERE fk_idMueble = 1);
END

EXEC Prueba @pIdFactura = 18

select * from Compra
go
-- CREATE COMPRA
CREATE PROCEDURE FacturarLineaCompra(@pIdFactura int, @pIdMueble int, @pCantidad int)
AS
    BEGIN
        declare @error varchar(20)
        IF(@pIdFactura IS NOT NULL AND @pIdMueble IS NOT NULL AND @pCantidad IS NOT NULL)
            BEGIN
            IF    ((SELECT COUNT(idFactura) FROM Facturacion WHERE idFactura = @pIdFactura) = 0
                 OR (SELECT COUNT(idMueble) FROM Mueble WHERE idMueble = @pIdMueble )= 0 OR (@pCantidad < 1) OR (@@ERROR <>0))
                 BEGIN
                    set @error = 'ocurrió un problema'
                    print @error
                 END
            ELSE
                BEGIN
                IF ((SELECT (stock - @pCantidad) FROM Inventario WHERE fk_idMueble = @pIdMueble) >= 0)
                    BEGIN
                        INSERT INTO Compra(fk_factura, fk_idMuebleCompra, cantidad, costo) VALUES (@pIdFactura, @pIdMueble, @pCantidad,
                               (SELECT (precio)*@pCantidad FROM Mueble WHERE idMueble = @pIdMueble))
                        UPDATE Inventario SET stock = (SELECT (stock - @pCantidad) FROM Inventario WHERE fk_idMueble = @pIdMueble);
                        --RETURN (SELECT precio*@pCantidad FROM Mueble WHERE idMueble = @pIdMueble);
                    END
                ELSE
                    BEGIN
                        set @error = 'No hay suficiente inventario'
                        Print @error
                    END
                END
            END
    END
GO

EXEC FacturarLineaCompra @pIdFactura = 15, @pidMueble = 1, @pCantidad = 2
-- CREATE FACTURACION
go
create procedure insertFacturacion(@pNombre varchar(25), @pApellido varchar(25))
as
    BEGIN
        INSERT INTO Facturacion(NOMBRECLIENTE, APELLIDOCLIENTE) VALUES(ISNULL(@pNombre, 'Anonimo'),ISNULL(@pApellido, 'Anonimo') )
		SELECT SCOPE_IDENTITY() AS 'idFactura'
	end

/*
create unique index Inventario_fk_idMueble_uindex
        on Inventario (fk_idMueble)
go
*/

create unique index Mueble_fk_idTipoMueble_uindex
    on Mueble (fk_idTipoMueble)
go

create unique index Mueble_fk_idCategoria_uindex
    on Mueble (fk_idCategoria)
go

create unique index Mueble_fk_idMaterial_uindex
    on Mueble (fk_idMaterial)
go

create unique index TipoMueble_idMueble_uindex
    on TipoMueble (idMueble)
go

Insert into TipoMueble(nombre)VALUES ('Mesa')
go

Insert into Categoria(nombre)VALUES ('Playa')
go
INSERT INTO Categoria(nombre) VALUES ('Ejecutivo')
go
INSERT INTO Categoria (nombre)VALUES ('Rústico')
go

INSERT INTO Material( nombre) VALUES ( 'Madera')
go
INSERT INTO Material(nombre) VALUES ( 'Aluminio')
go
INSERT INTO Material(nombre) VALUES ('Plástico')
INSERT INTO Material( nombre) VALUES ( 'Plástico')

INSERT INTO TipoMueble( nombre) VALUES ( 'Sofa')
go
INSERT INTO TipoMueble(nombre) VALUES ( 'Mesa')
go
INSERT INTO TipoMueble( nombre) VALUES ( 'Silla')
go

INSERT INTO Mueble(color, precio, cuidados, fk_idTipoMueble, fk_idCategoria, fk_idMaterial) VALUES ('café', 200000, 'No mojar', 1, 3, 1)
INSERT INTO Mueble(color, precio, cuidados, fk_idTipoMueble, fk_idCategoria, fk_idMaterial) VALUES ('negro', 120000, 'No rasgar y no mojar. Peso máximo de 120kg', 3, 2, 3)
go
SELECT * FROM TipoMueble
SELECT * FROM Categoria
SELECT * FROM Material

go
------------------------------  CRUD productos --------------------------------------------------------
--Agregar Funcion o procedimientoLos productos se deben de poder agregar al inventario (CRUD)
------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CInventario @idProducto int, @cantidad int
as
begin
	begin transaction
	if ((SELECT COUNT(idMueble) FROM Mueble Where @idProducto =idMueble) = 1 AND @idProducto is not null and @cantidad is not null)
		begin
			if @cantidad >0
				begin
						IF((SELECT COUNT(fk_idMueble) FROM Inventario WHERE @idProducto = @idProducto)=0)
						begin
							INSERT INTO Inventario (fk_idMueble,stock) VALUES (@idProducto, @cantidad)
						end
						ELSE
							begin
								UPDATE Inventario set stock = (SELECT stock+@cantidad FROM Inventario WHERE @idProducto= fk_idMueble) WHERE @idProducto = fk_idMueble
							end
				end
			else
				begin
				PRINT N'La cantidad no puede ser menor a 0';
				end
		end
	else
		begin
			 PRINT N'No existe el id del producto para agregar al inventario';
		end
	commit transaction
end
go

CREATE PROCEDURE ConsultaInventario @idProducto int = NULL, @cantidad int = NULL
as
begin
	--SELECT fk_idMueble, stock FROM Inventario WHERE fk_idMueble = ISNULL(@idProducto, fk_idMueble) AND stock = ISNULL(@cantidad, stock)
	--SELECT idMueble, nombre, precio, stock FROM Inventario INNER JOIN Mueble on Inventario.fk_idMueble = Mueble.idMueble
	SELECT Mueble.idMueble, precio AS 'Precio en Colones', stock, TipoMueble.nombre AS 'Tipo de Mueble',
			Categoria.nombre AS 'Categoria', Material.nombre AS 'Material' 
			FROM Inventario INNER JOIN Mueble on Inventario.fk_idMueble = Mueble.idMueble
			INNER JOIN TipoMueble ON Mueble.fk_idTipoMueble = TipoMueble.idMueble
			INNER JOIN Categoria ON Mueble.fk_idCategoria = Categoria.idCategoria
			INNER JOIN Material ON Mueble.fk_idMaterial = Material.idMaterial
			WHERE fk_idMueble = ISNULL(@idProducto, fk_idMueble) AND stock = ISNULL(@cantidad, stock)
end
go
CREATE PROCEDURE DInventario @idProducto int
as
begin
	IF @idProducto is not null
	BEGIN
		delete Inventario from Inventario where @idProducto = fk_idMueble
	END
	ELSE
	BEGIN
		PRINT N'Debe contener un id válido de mueble'
	END

end
go
EXEC ConsultaInventario

EXEC CInventario @idProducto = 1, @cantidad = 30
select * FROM Mueble
------------------------------  Función de Consulta --------------------------------------------------------
/*Funcion Consulta con parametros opcionales: Un cliente puede ver los productos existentes, consultar por
tipo de mueble, o verlos todos, se debe mostrar la imagen del producto, las características, precio, y
demás información*/
------------------------------------------------------------------------------------------------------------
go
CREATE PROCEDURE ConsultarMuebles @tipoConsulta int= NULL, @idTipoMueble int = NULL
AS
BEGIN
	if (@tipoConsulta is not null)
		BEGIN
			IF (@tipoConsulta = 1)
				SELECT Mueble.idMueble, color, precio AS 'Precio en Colones', cuidados, imagen, TipoMueble.nombre AS 'Tipo de Mueble',
				Categoria.nombre AS 'Categoria', Material.nombre AS 'Material' FROM Mueble INNER JOIN TipoMueble ON Mueble.fk_idTipoMueble = TipoMueble.idMueble
				INNER JOIN Categoria ON Mueble.fk_idCategoria = Categoria.idCategoria
				INNER JOIN Material ON Mueble.fk_idMaterial = Material.idMaterial
			ELSE IF (@tipoConsulta = 2)
				SELECT Mueble.idMueble, color, precio AS 'Precio en Colones', cuidados, imagen, TipoMueble.nombre AS 'Tipo de Mueble',
				Categoria.nombre AS 'Categoria', Material.nombre AS 'Material' FROM Mueble INNER JOIN TipoMueble ON Mueble.fk_idTipoMueble = TipoMueble.idMueble
				INNER JOIN Categoria ON Mueble.fk_idCategoria = Categoria.idCategoria
				INNER JOIN Material ON Mueble.fk_idMaterial = Material.idMaterial
				WHERE fk_idTipoMueble = @idTipoMueble
		END
END;

select * from Mueble

INSERT INTO Mueble(color, precio, cuidados, fk_idTipoMueble, fk_idCategoria, fk_idMaterial, imagen) VALUES ('café', 200000, 'No mojar', 1, 3, 1, 'image.jpg')
go

INSERT INTO Facturacion(nombreCliente,apellidoCliente) VALUES ('Luis', 'Fonseca');

INSERT INTO Inventario(fk_idMueble, stock) VALUES (1,5)
INSERT INTO Inventario(fk_idMueble, stock) VALUES (2,5)

--Insert Into Compra(fk_factura, fk_idMuebleCompra, cantidad, costo) Values(1,1,2,20000);
EXECUTE FacturarLineaCompra @pIdFactura = 1, @pIdMueble = 1, @pCantidad = 2;

EXECUTE insertFacturacion @pNombre = NULL, @pApellido = NULL

SELECT * FROM Compra
