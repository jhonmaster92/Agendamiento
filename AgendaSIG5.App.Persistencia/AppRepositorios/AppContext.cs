using Microsoft.EntityFrameworkCore;
using AgendaSIG5.App.Dominio;

namespace AgendaSIG5.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas {get;set;}
       public DbSet<Paciente> Pacientes {get;set;} 
       public DbSet<Sede> Sedes {get;set;}
       //public DbSet<Laboratorio> Laboratorios {get;set;} 
       //public DbSet<Especialidad> Especialidades {get;set;}
       //public DbSet<Eps> Epss {get;set;} 
       //public DbSet<Doctor> Doctores {get;set;}
       //public DbSet<Convenio> Convenios {get;set;} 
       //public DbSet<AgendaCita> AgendaCitas {get;set;}
       //public DbSet<AgendaLaboratorio> AgendaLaboratorios {get;set;} 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AgendaSIG5Data");
            }
        }    
    }
}