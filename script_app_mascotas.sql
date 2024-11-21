drop database  app_Mascotas;
create database app_Mascotas; 
go
use app_Mascotas; 
go 


create table usuario (
idUsuario int primary key not null identity(1,1),
nombre nvarchar (50) not null , 
contraseña nvarchar (20) not null, 
estado bit not null

);
create table dueño (
idDueño int primary key not null identity (1,1), 
idUsuario int not null,
nombre nvarchar(50) not null,
apellido nvarchar (50) not null,
telefono int not null, 
mail nvarchar (50), 
direccion nvarchar(50) not null,
estado bit not null 
foreign key (idusuario) references usuario(idUsuario)


);



create table mascota (
idMascota int primary key not null identity(1,1),
nombre nvarchar(30) not null , 
raza nvarchar(30),
fechaNacimiento date not null,
fotoUrl nvarchar (260) not null,
estado bit not null ,
idDueño int not null,
foreign key (idDueño) references dueño (idDueño)
);


create table QR_paginas (
    qrId NVARCHAR(50) PRIMARY KEY,
    urlQr NVARCHAR(255),
    estado bit not null default 0 
);
insert into usuario (nombre,contraseña,estado) values ('admin','admin',1)
insert into dueño (idUsuario, nombre,apellido, telefono,mail,direccion,estado) values 
(1,'Gerardo','Veliz',1124090490,'gera.vz@gmail.com','av juan domingo peron 4303',1)
select * from dueño
select * from mascota