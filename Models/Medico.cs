using System.ComponentModel.DataAnnotations;

namespace GestorCitasHospital.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Especialidad { get; set; }

        public string? Telefono { get; set; }

        public string? Correo { get; set; }
    }
}