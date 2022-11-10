using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using G5_CASO2.Models;

namespace G5_CASO2.Models.ViewModel
{
    public class EmpleadoModel
    {
        [Display(Name = "Identificacion")]
        [Required (ErrorMessage ="Campo Requerido")]
        public int ID_EMPLEADO { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, ErrorMessage = "El tamaño no debe superar los 30 caracteres")]
        public string NOMBRE { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, ErrorMessage = "El tamaño no debe superar los 30 caracteres")]
        public string APELLIDO { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Range(18, 65, ErrorMessage ="La edad debe estar entre 18 y 65 años")]
        public decimal EDAD { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public decimal SALARIO { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(30, ErrorMessage = "El tamaño no debe superar los 30 caracteres")]
        [Display(Name = "Correo")]
        public string Email { get; set; }
    }

    //VALIDA EL ID
    public class IDExiste : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            using (G5_CASO2Entities db = new G5_CASO2Entities())
            {
                int id_empleado = (int)value;
                if (db.EMPLEADO.Where(d => d.ID_EMPLEADO == id_empleado).Count() > 0)
                {
                    return new ValidationResult("El empleado ya existe.");
                }

                return ValidationResult.Success;
            }
        }

    }
}