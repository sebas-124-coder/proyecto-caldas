using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace proyecto_caldas.Models
{
    public class usuariomodel
    {
        public int Userid { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public required string Usuario_Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es obligatorio")]
        public required string Usuario_Apellido { get; set; }
        [Required(ErrorMessage = "El Correo es obligatorio")]
        public required string Usuario_Correo { get; set; }
        [Required(ErrorMessage = "La Contraseña es obligatorio")]
        [MinLength(6, ErrorMessage = "La Contraseña debe tener al menos 6 caracteres")]
        public required string Usuario_Contrasena { get; set; }
    }
}