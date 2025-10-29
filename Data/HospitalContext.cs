using Microsoft.EntityFrameworkCore;
using GestorCitasHospital.Models;

namespace GestorCitasHospital.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cita> Citas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=hospital.db");
        }
    }
}