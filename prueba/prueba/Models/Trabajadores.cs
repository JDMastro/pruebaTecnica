using prueba.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Models
{
    public class Trabajadores
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es requerido un Nombre para el trabajador")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El campo nombre no debe ser menor de 3 carateres o mayor de 20 caracteres")]
        [Display(Name = "Nombres del trabajador")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Es requerido un Apellido para el trabajador")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El campo apellido no debe ser menor de 3 carateres o mayor de 20 caracteres")]
        [Display(Name = "Apellidos del trabajador")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Es requerido una direcciòn para el trabajador")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El campo direcciòn no debe ser menor de 3 carateres o mayor de 20 caracteres")]
        [Display(Name = "Direccion del trabajador")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Es requerido el Teléfono para el trabajador")]
        [Phone]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "El campo Teléfono no debe ser menor de 6 carateres o mayor de 10 caracteres")]
        [Display(Name = "Teléfono del trabajador")]
        [CheckTelefono]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Es requerido el salario para el trabajador")]
        [Range(0, int.MaxValue, ErrorMessage = "Por favor ingrese un valor valido")]
        [Display(Name = "Salario del trabajador")]
        public int Salario { get; set; }

        [Required(ErrorMessage = "Es requerido un area para el trabajador")]
        [Display(Name = "Area a la que va a pertenecer el trabajador")]
        public int AreasId { get; set; }

        [Required(ErrorMessage = "Es requerido una fecha de ingreso para el trabajador")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de ingreso del trabajador")]
        public DateTime FechaIngreso { get; set; }


        [Required(ErrorMessage = "Es requerido una direcciòn para el trabajador")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El campo sexo no debe ser menor de 5 carateres o mayor de 15 caracteres")]
        [Display(Name = "Sexo del trabajador")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Es requerido una empresa para el trabajador")]
        [Display(Name = "Empresa a la que pertenece el trabajador")]
        public int EmpresasId { get; set; }

        public Areas Areas { get; set; }
    }
}
