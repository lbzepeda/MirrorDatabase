using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MirrorDataBase.Model;
using SlackAPI;

namespace MirrorDataBase
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetFactura> DetFacturas { get; set; }
        public DbSet<Proforma> Proformas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetFactura>()
                .HasKey(c => new { c.Sucursal, c.NoFactura, c.Serie, c.Producto, c.Bod_Descargue, c.Numero, c.cod_combo, c.indice, c.TipoServicio });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SQL
            string sqlServer = Environment.GetEnvironmentVariable("SQL_SERVER") ?? "";
            string sqlDatabase = Environment.GetEnvironmentVariable("SQL_DATABASE") ?? "";
            string sqlUser = Environment.GetEnvironmentVariable("SQL_USER") ?? "";
            string sqlPassword = Environment.GetEnvironmentVariable("SQL_PASSWORD") ?? "";
            optionsBuilder.UseSqlServer($@"Data Source={sqlServer};Initial Catalog={sqlDatabase};User ID={sqlUser};Password={sqlPassword};Connect Timeout=60;TrustServerCertificate=True;");
        }
    }

    public class MySqlDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetFactura> DetFacturas { get; set; }
        public DbSet<Proforma> Proformas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetFactura>()
                .HasKey(c => new { c.Sucursal, c.NoFactura, c.Serie, c.Producto, c.Bod_Descargue, c.Numero, c.cod_combo, c.indice, c.TipoServicio });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //MySQL
            string mySqlServer = Environment.GetEnvironmentVariable("MYSQL_SERVER") ?? "";
            string mySqlPort = Environment.GetEnvironmentVariable("MYSQL_PORT") ?? "";
            string mySqlDatabase = Environment.GetEnvironmentVariable("MYSQL_DATABASE") ?? "";
            string mySqlUser = Environment.GetEnvironmentVariable("MYSQL_USER") ?? "";
            string mySqlPassword = Environment.GetEnvironmentVariable("MYSQL_PASSWORD") ?? "";

            optionsBuilder.UseMySql($@"server={mySqlServer};port={mySqlPort};database={mySqlDatabase};user={mySqlUser};password={mySqlPassword}", 
                            new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string token = Environment.GetEnvironmentVariable("TOKENSLACK") ?? "";
            SlackClient slackClient = new SlackClient(token);

            //Cliente//
            using (var dbSql = new SqlDbContext())
            using (var dbMySql = new MySqlDbContext())
            {
                var codClientesMySql = dbMySql.Clientes.Select(c => c.CodCliente).ToList();
                var clientesToAdd = dbSql.Clientes
                    .Where(c => !codClientesMySql.Contains(c.CodCliente))
                    .ToList();

                foreach (var cliente in clientesToAdd)
                {
                    dbMySql.Clientes.Add(cliente);
                    Console.WriteLine($"Insertado en MySQL Cliente -> ID: {cliente.CodCliente}, Nombre: {cliente.Nombres}, Apellido: {cliente.Apellidos}");

                    slackClient.PostMessage(response =>
                    {
                        Console.WriteLine("Message sent? " + response.error);
                    },
                    channelId: "C05HDSRQ13P",
                    icon_emoji: ":robot_face:",
                    text: $"*{cliente.Nombres}* ahora forma parte de nuestra lista de clientes. Registro creado por *{cliente.UsuarioRegistro}* :tada:");

                }

                dbMySql.SaveChanges();
            }

            //Factura//
            using (var dbSql = new SqlDbContext())
            using (var dbMySql = new MySqlDbContext())
            {
                var noFacturasMySql = dbMySql.Facturas.Select(f => f.NoFactura).ToList();
                var facturasToAdd = dbSql.Facturas
                    .Where(f => !noFacturasMySql.Contains(f.NoFactura))
                    .ToList();

                foreach (var factura in facturasToAdd)
                {
                    dbMySql.Facturas.Add(factura);
                    Console.WriteLine($"Insertado en MySQL Factura-> ID: {factura.NoFactura}, Detalles: {factura.Nombrede}");
                }

                dbMySql.SaveChanges();
            }


            //DetFactura//
            using (var dbSql = new SqlDbContext())
            using (var dbMySql = new MySqlDbContext())
            {
                var noFacturasMySql = dbMySql.DetFacturas.Select(f => f.NoFactura).ToList();
                var facturasToAdd = dbSql.DetFacturas
                    .Where(f => !noFacturasMySql.Contains(f.NoFactura))
                    .ToList();

                foreach (var factura in facturasToAdd)
                {
                    dbMySql.DetFacturas.Add(factura);
                    Console.WriteLine($"Insertado en MySQL DetFactura-> ID: {factura.NoFactura}");
                }

                dbMySql.SaveChanges();
            }

            //Proformas//
            using (var dbSql = new SqlDbContext())
            using (var dbMySql = new MySqlDbContext())
            {
                var noFacturasMySql = dbMySql.Proformas.Select(c => c.NoFactura).ToList();
                var clientesToAdd = dbSql.Proformas
                    .Where(c => !noFacturasMySql.Contains(c.NoFactura))
                    .ToList();

                foreach (var cliente in clientesToAdd)
                {
                    dbMySql.Proformas.Add(cliente);
                    slackClient.PostMessage(response =>
                    {
                        Console.WriteLine("Message sent? " + response.error);
                    },
                    channelId: "C05HGSR2Z7C",
                    icon_emoji: ":robot_face:",
                    text: $"Se creo una nueva cotización a nombre de *{cliente.Nombrede}*, Codigo Cliente: *{cliente.CodCli}* por el vendedor *{cliente.RegistroUsuario}*. Cotización No. *{cliente.NoFactura}*");

                    Console.WriteLine($"Insertado en MySQL Proformas-> ID: {cliente.NoFactura}");
                }

                dbMySql.SaveChanges();
            }

            //Productos//
            using (var dbSql = new SqlDbContext())
            using (var dbMySql = new MySqlDbContext())
            {
                var codProductosMySql = dbMySql.Productos.Select(c => c.CodProducto).ToList();
                var clientesToAdd = dbSql.Productos
                    .Where(c => !codProductosMySql.Contains(c.CodProducto))
                    .ToList();

                foreach (var cliente in clientesToAdd)
                {
                    dbMySql.Productos.Add(cliente);
                    Console.WriteLine($"Insertado en MySQL Productos-> ID: {cliente.CodProducto}");
                }

                dbMySql.SaveChanges();
            }

            Console.WriteLine($"FIN");

        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var properties = GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.GetValue(this) != property.GetValue(obj))
                {
                    return false;
                }
            }

            return true;
        }


    }
}
