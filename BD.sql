create database imagesVisualizer;
-- drop database imagesVisualizer;
use imagesVisualizer;

create table usuarios(
	id int auto_increment primary key,
    nombre varchar(50),
    apaterno varchar(30),
    amaterno varchar(30),
    username varchar(30),
    email varchar(60),
    pwd text
);
select * from usuarios;