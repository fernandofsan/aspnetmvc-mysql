using MySql.Data.Entity;
using System.Data.Entity;

namespace TestMySQL.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }

        public ApplicationDbContext(): base("DefaultConnection")
        {
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}