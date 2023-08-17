using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaLiga2023.Modelos
{
    public class Equipos
    {
        [Key]
        public int id_equipo { get; set; }

        [Required(ErrorMessage ="Nombre oficial es requerido")]
        [MaxLength(50, ErrorMessage = "Nombre debe ser máximo 50 caracteres")]
        public string nombre_oficial { get; set; }

        [Required(ErrorMessage = "Nombre coloquial es requerido")]
        [MaxLength(30, ErrorMessage = "Nombre coloquial debe ser máximo 30 caracteres")]
        public string nombre_coloquial { get; set; }

        [Required(ErrorMessage = "Fundacion es requerido")]
        [MaxLength(4, ErrorMessage = "Fundación debe ser máximo 4 caracteres")]
        public int fundacion { get; set; }

        [Required(ErrorMessage = "Estadio es requerido")]
        [MaxLength(35, ErrorMessage = "Estadio debe ser máximo 35 caracteres")]
        public string estadio { get; set; }

        [Required(ErrorMessage = "Presidente es requerido")]
        [MaxLength(35, ErrorMessage = "Presidente debe ser máximo 35 caracteres")]
        public string presidente { get; set; }

        [Required(ErrorMessage = "Web es requerido")]
        [MaxLength(50, ErrorMessage = "Nombre debe ser máximo 50 caracteres")]
        public string web { get; set; }

        [Required(ErrorMessage = "Entrenador es requerido")]
        [MaxLength(40, ErrorMessage = "Nombre debe ser máximo 40 caracteres")]
        public string entrenador { get; set; }
    }
}
