using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KubernetesAzure.Models
{

    [Table(name: "ApiRest")]
    public class Employee
        {
            [Key]
            public int id { get; set; }

            public string Nombre { get; set; }

            public string DNI { get; set; }

            public short? Edad { get; set; }

            public string Telefono { get; set; }

            public string Correo { get; set; }

            public decimal? Basico { get; set; }

            public DateTime? Ingreso { get; set; }

            public bool? Activo { get; set; }
        }

        public class EmployeeContext : DbContext
        {
            public EmployeeContext(DbContextOptions options) : base(options) { }
            public DbSet<Employee> Employees { get; set; }
        }

}
