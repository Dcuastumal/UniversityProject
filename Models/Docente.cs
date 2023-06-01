public class Docente
{
    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public List<string> Cursos { get; set; } = new List<string>();
    public bool CursoRepetido { get; set; } = false;
}