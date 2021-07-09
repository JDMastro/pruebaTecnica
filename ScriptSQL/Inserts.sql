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
select * from areas;
END

*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpObtenerPorId`(in Vid int)
BEGIN
   select * from areas where id = Vid;
END

*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpActualizarArea`(in Vid int, in Vdescripcion varchar(255))
BEGIN
 update areas set Descripcion = Vdescripcion where Id = Vid;
 select * from areas;
END

*/

/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpObtenerTrabajadores`()
BEGIN
  select * from trabajadores;
END

*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpObtenerEmpresas`()
BEGIN
select * from empresas;
END
*/
/*

CREATE DEFINER=`root`@`localhost` PROCEDURE `SpInsertarTrabajadorJefe`(
  in Vnombres varchar(20), in Vapellidos varchar(20), in Vdireccion varchar(20),
  in Vtelefono varchar(10), in Vsalario int, in VareasId int, in VfechaIngreso datetime,
  in Vsexo varchar(15), in VempresasId int
)
BEGIN
  insert into trabajadores(
  nombres, apellidos, direccion, telefono, salario, areasId, fechaIngreso,
     sexo, empresasId
  ) values(
  Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso,
  Vsexo, VempresasId);
  
  SET @lastId = LAST_INSERT_ID();
  
  update areas set TrabajadoresId = @lastId where id = VareasId;
  
  select * from trabajadores;
END
*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpUpdateTrabajadorJefe`(
in Vid int,
in Vnombres varchar(20), 
in Vapellidos varchar (20),
in Vdireccion varchar (20),
in Vtelefono varchar(10),
in Vsalario int
)
BEGIN
  update trabajadores
    set Nombres = Vnombres, 
    Apellidos = Vapellidos, 
    Direccion = Vdireccion,
    Telefono = Vtelefono,
    Salario = Vsalario
    
    where Id = Vid;
    
    select * from trabajadores;
END
*/
/*
CREATE DEFINER=`root`@`localhost` PROCEDURE `SpInsertarTrabajadorNormal`(
  in Vnombres varchar(20), in Vapellidos varchar(20), in Vdireccion varchar(20),
  in Vtelefono varchar(10), in Vsalario int, in VareasId int, in VfechaIngreso datetime,
  in Vsexo varchar(15), in VempresasId int
)
BEGIN
  insert into trabajadores(
  nombres, apellidos, direccion, telefono, salario, areasId, fechaIngreso,
     sexo, empresasId
  ) values(
  Vnombres, Vapellidos, Vdireccion, Vtelefono, Vsalario, VareasId, VfechaIngreso,
  Vsexo, VempresasId);
  
  select * from trabajadores;
END

*/

select * from empresas
select * from areas where TrabajadoresId != 0