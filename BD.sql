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
drop table imagenes;
create table imagenes(
	id int auto_increment primary key,
    id_usuario int,
    imagen longtext,
    constraint fk_ui foreign key(id_usuario) references usuarios(id)
);

select * from usuarios;
select * from imagenes;