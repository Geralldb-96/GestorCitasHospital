using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestorCitasHospital.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Estado { get; set; } // Ej: Pendiente, Confirmada, Cancelada

        // Relación con Paciente
        [Required]
        public string DocumentoPaciente { get; set; }

        [ForeignKey("DocumentoPaciente")]
        public Paciente Paciente { get; set; }

        // Relación con Médico
        [Required]
        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}