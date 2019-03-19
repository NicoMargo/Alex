Create Database Database_Ecommerce;
USE Database_Ecommerce;
Create Table Users(
    Id int Not Null PRIMARY KEY AUTO_INCREMENT,
    Username varchar(20) Not Null,
    pass varchar(60) Not Null,
    Nombre varchar(40) Not Null,
    Apellido varchar(40) Not Null,
    Mail varchar(40) Not Null
);
run