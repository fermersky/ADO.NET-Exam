--DESKTOP-27H75VF

create database Library


create table Authors
(
	Id int primary key identity,
	FirstName nvarchar(20),
	LastName nvarchar(20),
)

insert into Authors values 
('George', 'Oruel'), 
('Mikhail', 'Lermontov'), 
('Lev', 'Tolstoi'),
('Franz', 'kafka'),
('Jerome', 'Salinger'),
('Mo', 'Yan'),
('Taras', 'Shevchenko'),
('Scott', 'Walter'),
('Margaret', 'Atwood'),
('Mikhail', 'Bulgakov')

insert into Authors values 
('Arthur', 'Doyl'),
('Oscar', 'Wild'),
('George', 'Talking'),
('Fedor', 'Dostoevsky')

select * from Authors

create table Genres
(
	Id int primary key identity,
	GenreName varchar(40)
)

insert into Genres values ('Dramma'), ('Sci-Fi'), ('Horrors'), ('Fantasy')


create table Books
(
	Id int primary key identity,
	Title varchar(40),
	Publisher varchar(20),
	Pages int,
	Price varchar(10),
	PriceForSale varchar(10),
	PublishDate date,
	IsSequel varchar(40),
	IsDeleted bit,
	Discount int,
	Id_Author int foreign key references Authors(Id),
	Id_Genre int foreign key references Genres(Id),
	ImagePath varchar(100)
)

insert into Books values ('Voyna i Mir', 'Ukraine', 250, '24,5', '25,5', '20160101', '', 0, 0, 3, 1, 'voyna.png')
insert into Books values ('1984', 'Ukraine', 345, '21,5', '22,5', '20180101', '', 0, 0,  1, 1, '1984.png')
insert into Books values ('Kobzar', 'Ukraine', 652, '24,5', '25,5', '20180101', '', 0, 0, 7, 1, 'kobzar.png')
insert into Books values ('Prevrashenie', 'Ukraine', 512, '24,5', '25,5', '20180101', '', 0, 0,  4, 4, 'zamok.png')
insert into Books values ('Geroi nashego vremeni', 'Ukraine', 878, '24,5', '25,5', '20170101', '', 0, 0,  2, 1, 'geroi.png')
insert into Books values ('Nad Propastu vo rji', 'Ukraine', 453, '20,5', '22,5', '20140101', '', 0, 0,  5, 1, 'nad.png')

insert into Books values ('Otsy i deti', 'Russia', 250, '24,5', '25,5', '20160101', '', 0, 0, 3, 1, 'otsi.png')
insert into Books values ('Adventure of Sherlock Holmes', 'Birtan', 345, '21,5', '22,5', '20180101', '', 0, 0,  11, 1, 'sh.png')
insert into Books values ('Dogs Heart', 'Ukraine', 512, '24,5', '25,5', '20180101', '', 0, 0,  10, 4, 'dog.png')
insert into Books values ('Prestuplenie i nakazanie', 'Ukraine', 878, '24,5', '25,5', '20170101', '', 0, 0,  14, 1, 'pre.png')
insert into Books values ('Lord of Rings', 'USA', 453, '20,5', '22,5', '20140101', '', 0, 0,  13, 4, 'lord.png')

insert into Books values ('Kobzar', 'Ukraine', 652, '24,5', '25,5', '20180101', '', 0, 0, 7, 1, 'kobzar.png')
insert into Books values ('Otsy i deti', 'Russia', 250, '24,5', '25,5', '20160101', '', 0, 0, 3, 1, 'otsi.png')

create table Users
(
	Id int primary key identity,
	Lgn varchar(20),
	Pwd varchar(20)
)

insert into Users values ('arina', 'girl505'), ('daniel', 'sozdatel505')

create table UserBooks
(
	Id_User int foreign key references Users(Id),
	Id_Book int foreign key references Books(Id),
)

create table Admins
(
	Id int primary key identity,
	Lgn varchar(20),
	Pwd varchar(20)
)

insert into Admins values ('volodya', 'bes1_admin')

create table Sales
(
	[DateOfSale] date,
	Price varchar(20),
	Id_Book int foreign key references Books(Id)
)

/*
Books 
Authors, fn, ln
Genres, name
Sales: id_book, id_user, count
Users: fn, ln
UsersBooks: id_user, id_book
Admins: lgn, pwd
*/