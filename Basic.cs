using Microsoft.EntityFrameworkCore;
using MirrorDataBase.Model;


public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=20.120.95.95\ALASKACOOL;Initial Catalog=2201ALASKACOOL_CENTRAL;User ID=LZepeda;Password=Zepeda2023;Connect Timeout=60;TrustServerCertificate=True;");
    }
}

class Program2
{
    static void Main2(string[] args)
    {
        using (var db = new AppDbContext())
        {
            var clientes = db.Clientes.OrderBy(c => c.CodCliente).ToList();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.CodCliente}, Nombre: {cliente.Nombres}, Apellido: {cliente.Apellidos}");
            }
        }
    }
}
