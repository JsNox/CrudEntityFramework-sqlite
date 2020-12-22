using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Display(Name = "Teléfono")]
        //Display nos deja agregar el campo cib tildes o caracteres UTF-8
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Email { get; set; }
    }
}
