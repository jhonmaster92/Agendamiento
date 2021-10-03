using System;

namespace AgendaSIG5.App.Dominio
{
    public class Paciente : Persona
    {
        public string Direccion { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public int Id_Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Medico Medico { get; set; }
        public string Eps { get; set; }
        public int Id_sede { get; set; }
    }
}