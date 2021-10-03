using System;
namespace AgendaSIG5.App.Dominio
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public string Codigo { get; set; }
        public string RegistroMedico { get; set; }
    }
}