using System.ComponentModel.DataAnnotations;

public class Paciente
{
    [Key]
    public string Documento { get; set; }

    [Required]
    public string Nombre { get; set; }

    public DateTime FechaNacimiento { get; set; }
}