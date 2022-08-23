create database fahrtenbuch;
use fahrtenbuch;

create table fahrt
(
	id int not null auto_increment,
    fahrtnummer int,
    stadt varchar(50),
    bundesland varchar(50),
    entfernung float,
    primary key(id)
);    