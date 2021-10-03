namespace AgendaSIG5.App.Dominio
{
    public class Agenda
    {
        public int Id { get; set; }
        public int Id_sede { get; set; }
        public int Id_paciente { get; set; }
        public int Id_medico { get; set; }
        public Datetime FechaCita { get; set; }
        public string Notas { get; set; }
    }
}