using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente); 
    }
}
//Interface: Conjunto de métodos-encabezad