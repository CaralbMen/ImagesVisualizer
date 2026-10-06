create database imagesVisualizer;

use imagesVisualizer;

create table usuarios(
	id int auto_increment primary key,
    username varchar(30),
    pwd text,
    email varchar(60)
);