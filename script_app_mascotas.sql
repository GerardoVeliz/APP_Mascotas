create database app_Mascotas; 
go
use app_Mascotas; 
go 

select nombre, contraseña from usuario where nombre = @nombre and contraseña=@contraseña
insert into usuario (nombre,contraseña,estado) values ('admin','admin',1)
select * from usuario
create table usuario (
idUsuario int primary key not null identity(1,1),
nombre nvarchar (50) not null , 
contraseña nvarchar (20) not null, 
estado bit not null

);
update dueño set nombre=@nombre , apellido=@apellido , telefono = @telefono , mail=@mail, direccion=@direccion where idDueño=@idDueño
create table dueño (
idDueño int primary key not null identity (1,1), 
nombre nvarchar(50) not null,
apellido nvarchar (50) not null,
telefono int not null, 
mail nvarchar (50), 
direccion nvarchar(50) not null,
estado bit not null 



);

update mascota set nombre=@nombre, raza=@raza,fechaNacimiento=@fechaNacimiento, fotoUrl=@fotoUrl where idMascota = @idMascota

create table mascota (
idMascota int primary key not null identity(1,1),
nombre nvarchar(30) not null , 
raza nvarchar(30),
fechaNacimiento date not null,
fotoUrl nvarchar (50) not null,
estado bit not null ,
idDueño int not null,
foreign key (idDueño) references dueño (idDueño)
);


create table QR_paginas (
    qrId NVARCHAR(50) PRIMARY KEY,
    urlQr NVARCHAR(255),
    estado bit not null default 0 
);