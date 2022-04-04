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
    imagen          image       not null,
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

-- CREATE FACTURACION
create procedure insertFacturacion(@pNombre varchar(25), @pApellido varchar(25))
as
    BEGIN
        INSERT INTO Facturacion(NOMBRECLIENTE, APELLIDOCLIENTE) VALUES(ISNULL(@pNombre, 'Anonimo'),ISNULL(@pApellido, 'Anonimo') )
    end


create unique index Inventario_fk_idMueble_uindex
        on Inventario (fk_idMueble)
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
go

INSERT INTO Mueble(color, precio, cuidados, fk_idTipoMueble, fk_idCategoria, fk_idMaterial, imagen) VALUES ('café', 200000, 'No mojar', 1, 3, 1, 'image.jpg')
go

INSERT INTO Facturacion(nombreCliente,apellidoCliente) VALUES ('Luis', 'Fonseca');

INSERT INTO Inventario(fk_idMueble, stock) VALUES (3,5)

--Insert Into Compra(fk_factura, fk_idMuebleCompra, cantidad, costo) Values(1,1,2,20000);
EXECUTE FacturarLineaCompra @pIdFactura = 1, @pIdMueble = 3, @pCantidad = 2;

EXECUTE insertFacturacion @pNombre = NULL, @pApellido = NULL

SELECT * FROM Compra
