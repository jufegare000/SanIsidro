Create database hospitalsanisidro

use hostopitalsanisidro;


create table usuario(
 usuario varchar(100) primary key,
 nombre varchar(100),
 contrasena varchar(100))
 
  create table paciente(
  id int identity primary key not null, 
 nombre varchar(300),
 apellidos varchar(300),
 tipodedocumento varchar(10),
 numerodocumento varchar(20),
 paisdeorigen varchar(200),
 tiempodepermanenciaenmeses int,
 genero varchar(20),
 fechanacimiento varchar(100),
 edad int,
 estadocivil varchar(30),
 correoelectronico varchar(200),
 numerodehijos int,
 direccionresidencia varchar(300),
 barrioresidencia varchar(200),
 telefonocontacto varchar(20),
 ocupacion varchar(100),
 nivelescolaridad varchar(200),
 eps varchar(200),
 regimen varchar(100),
 antecedentesmedicos varchar(5000),
 convenio varchar(200),
 contactoemergencia varchar(30),
 masa float,
 peso float,
 estatura float,
 imcmvalor float,
 imcvalor float,
 imchvalor float,
 imcdescripcion varchar(30),
 formula varchar(5000)
 );
https://www.youtube.com/watch?v=JAfg2j8qrsg&ab_channel=hdeleon.net