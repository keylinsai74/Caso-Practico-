using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPP.Models
{
    public class Persona
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public bool Estado { get; set; }


        //      CREATE TABLE `u484426513_pac126`.`Persona` (
        //`Id` INT NULL AUTO_INCREMENT,
        //`Nombre` VARCHAR(100) NOT NULL,
        //`Apellido` VARCHAR(100) NOT NULL,
        //`Estado` TINYINT(1) NOT NULL,
        //PRIMARY KEY(`Id`));


    }
}