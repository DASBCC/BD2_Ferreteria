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
    fk_idMueble int identity
        constraint fk_idMueble
            references Mueble,
    stock       int not null
)
go

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

Insert into Categoria( nombre)VALUES ('Playa')
go
INSERT INTO Categoria( nombre) VALUES ('Ejecutivo')
go
INSERT INTO Categoria ( nombre)VALUES ( 'Rústico')
go

INSERT INTO Material( nombre) VALUES ( 'Madera')
go
INSERT INTO Material(nombre) VALUES ( 'Aluminio')
go
INSERT INTO Material( nombre) VALUES ( 'Plástico')

INSERT INTO TipoMueble( nombre) VALUES ( 'Sofa')
go
INSERT INTO TipoMueble(nombre) VALUES ( 'Mesa')
go
INSERT INTO TipoMueble( nombre) VALUES ( 'Silla')
go

INSERT INTO Mueble(color, precio, cuidados, fk_idTipoMueble, fk_idCategoria, fk_idMaterial) VALUES ('café', 200000, 'No mojar', 1, 3, 1)

go
SELECT * FROM Material
go
------------------------------  CRUD productos --------------------------------------------------------
--Agregar Funcion o procedimientoLos productos se deben de poder agregar al inventario (CRUD)
------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE CInventario @idProducto int, @cantidad int
as
begin
	begin transaction
	if ((SELECT COUNT(idMueble) FROM Mueble Where @idProducto =idMueble) <1 AND @idProducto is not null and @cantidad is not null)
		begin
			if @cantidad >0
				begin
						IF((SELECT COUNT(fk_idMueble) FROM Inventario WHERE @idProducto = @idProducto)>0)
						begin
							INSERT INTO Inventario (fk_idMueble,stock) VALUES (@idProducto, @cantidad)
						end
						ELSE 
							begin
								UPDATE Inventario set stock = @cantidad WHERE @idProducto = fk_idMueble
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

CREATE PROCEDURE ConsultaInventario @idProducto int, @cantidad int 
as
begin  
	SELECT fk_idMueble, stock FROM Inventario WHERE fk_idMueble = ISNULL(@idProducto, fk_idMueble) AND stock = ISNULL(@cantidad, stock)
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

------------------------------  Función de Consulta --------------------------------------------------------
/*Funcion Consulta con parametros opcionales: Un cliente puede ver los productos existentes, consultar por
tipo de mueble, o verlos todos, se debe mostrar la imagen del producto, las características, precio, y
demás información*/
------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE ConsultarMuebles @tipoConsulta int= NULL, @idTipoMueble int = NULL
AS
BEGIN
	if (@tipoConsulta is not null)
		BEGIN
			IF (@tipoConsulta = 1)
				SELECT * FROM Mueble
			ELSE IF (@tipoConsulta = 2)
				SELECT * FROM Mueble WHERE fk_idTipoMueble = @idTipoMueble
		END
END;