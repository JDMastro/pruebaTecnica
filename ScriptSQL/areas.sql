use test;

insert into empresas (Descripcion) values ('Google');
insert into empresas (Descripcion) values ('Facebook');
insert into empresas (Descripcion) values ('GitHub');
insert into empresas (Descripcion) values ('Oracle');

select * from empresas;



/*call test.SpObtenerAreas()*/

/*CREATE DEFINER=`root`@`localhost` PROCEDURE `SpObtenerAreas`()
BEGIN
SELECT * FROM areas;
END*/

/*

CREATE DEFINER=`root`@`localhost` PROCEDURE `SpInsertarAreas`(
  in Vdescripcion varchar(255)
)
BEGIN
insert into areas (Descripcion, TrabajadoresId) values (Vdescripcion, 0);
END

*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpObtenerPorId`(in Vid int)
BEGIN
   select * from areas where id = Vid;
END

*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpActualizarArea`(in id int, in Vdescripcion varchar(255))
BEGIN
 update areas set Descripcion = Vdescripcion where Id = Vid;
 select * from areas;
END

*/

