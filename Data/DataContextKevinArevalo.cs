using KevinArevaloPracticaViamatica1.Models;
using Microsoft.EntityFrameworkCore;

namespace KevinArevaloPracticaViamatica1.Data
{
    public class DataContextKevinArevalo : DbContext
    {
        public DataContextKevinArevalo(DbContextOptions<DataContextKevinArevalo> options) : base(options)
        {
        }
        public DbSet<Persona> persona { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
    }
}
