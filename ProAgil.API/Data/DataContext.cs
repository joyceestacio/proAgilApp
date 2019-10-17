using Microsoft.EntityFrameworkCore;
using ProAgil.API.Model;

namespace ProAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {} //DataContext nome da class que criei
       public DbSet <Evento> Eventos { get; set; } //Evento Model que criei
    }
}