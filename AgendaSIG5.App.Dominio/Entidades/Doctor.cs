using System;

namespace AgendaSIG5.App.Dominio
{
    public class Doctor
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string NumeroTelefono {get;set;}
        public Genero Genero {get;set;}
    }
}
