create table toys (id int,toy_name varchar(100),type_id int,supplier_id int,picture_location varchar(200),price float, amount int);
create table toy_types (id int, type_name varchar(20));
create table suppliers (id int, supplier_name varchar(20),address varchar(100),phone int, email varchar(50));
create table users (id int,username varchar(20),password varchar(20),user_type int);
create table user_types (type_id int, type_name varchar(10));


insert into toy_types values (1,'Plush Toy');
insert into toy_types values (2,'Baby Toy');
insert into toy_types values (3,'Figure');
insert into toy_types values (4,'Thinking Game');
insert into toy_types values (5,'Video game');
insert into toy_types values (6,'Doll');


insert into user_types values (1,'Admin');
insert into user_types values (2,'Costumer');
insert into user_types values (3,'Supplier');

insert into users values (1,'admin','admin',1);
insert into users values (3,'rick','rick',3);
insert into users values (2,'morty','morty',2);

insert into suppliers values (3,'Rick Sanchez','1-12 Sillicon Valley, LA, CA, USA',0505555555,'tinyRick@toysRus.com');

insert into toys values (1,'Cat plush toy',1,3,'',10.0,5);
insert into toys values (2,'Barbie',6,3,'',20.0,10);
insert into toys values (3,'Batman and Robin',3,3,'',5.5,1);
insert into toys values (4,'God of War 3',5,3,'',10.0,100);
insert into toys values (5,'Tiger toy',1,3,'',8.5,3);
