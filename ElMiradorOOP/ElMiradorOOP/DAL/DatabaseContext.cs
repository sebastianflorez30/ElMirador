using ElMiradorOOP.DAL.Entities;
using Microsoft.EntityFrameworkCore;



namespace ElMiradorOOP.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } //mapeo de la entidad para ser creada en la base de datos (en plural nombre de la tabla en la base)
    }
}
