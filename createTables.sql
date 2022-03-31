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


