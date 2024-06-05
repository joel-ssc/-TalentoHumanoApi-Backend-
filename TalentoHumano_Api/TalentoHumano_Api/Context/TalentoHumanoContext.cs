using Microsoft.EntityFrameworkCore;
using TalentoHumano_Api.Models;

namespace TalentoHumano_Api.Context
{
    public class TalentoHumanoContext : DbContext
    {
        public TalentoHumanoContext(DbContextOptions <TalentoHumanoContext> options ) : base (options)
        {

        }
        public DbSet<Empleado> Empleado { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Empleado>().ToTable("Empleado");
        //}
    }
}
