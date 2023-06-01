public class Estudiante : Persona
{
    public int NumeroCursos { get; set; } = 0;
    public List<string> Cursos { get; set; } = new List<string>();
    public List<double> Calificaciones { get; set; } = new List<double>();

    public void AgregarCursoCalificacion(string curso, double calificacion)
    {
        Cursos.Add(curso);
        Calificaciones.Add(calificacion);
        NumeroCursos++;
    }

    public List<string> ObtenerCursos()
    {
        return Cursos;
    }

    public double ObtenerPromedioCalificaciones()
    {
        if (Calificaciones.Count == 0)
            return 0;

        double sumaCalificaciones = 0;
        foreach (var calificacion in Calificaciones)
        {
            sumaCalificaciones += calificacion;
        }

        return sumaCalificaciones / Calificaciones.Count;
    }
}