public class TablaHashPacientes
{
    private Dictionary<string, Paciente> tabla = new();

    public void Agregar(Paciente paciente)
    {
        tabla[paciente.Documento] = paciente;
    }

    public Paciente Buscar(string documento)
    {
        return tabla.TryGetValue(documento, out var paciente) ? paciente : null;
    }

    public bool Eliminar(string documento)
    {
        return tabla.Remove(documento);
    }
}