create database app_Mascotas; 
go
use app_Mascotas; 
go 

select nombre, contrase�a from usuario where nombre = @nombre and contrase�a=@contrase�a
insert into usuario (nombre,contrase�a,estado) values ('admin','admin',1)
select * from usuario
create table usuario (
idUsuario int primary key not null identity(1,1),
nombre nvarchar (50) not null , 
contrase�a nvarchar (20) not null, 
estado bit not null

);
update due�o set nombre=@nombre , apellido=@apellido , telefono = @telefono , mail=@mail, direccion=@direccion where idDue�o=@idDue�o
create table due�o (
idDue�o int primary key not null identity (1,1), 
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
idDue�o int not null,
foreign key (idDue�o) references due�o (idDue�o)
);


create table QR_paginas (
    qrId NVARCHAR(50) PRIMARY KEY,
    urlQr NVARCHAR(255),
    estado bit not null default 0 
);