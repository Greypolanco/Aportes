public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aporte>().HasData(
            new Aporte {
                AporteId = 1,
                Fecha = DateTime.Today,
                PersonaId = 1,
                Concepto = "Pintura banco",
                Monto = 200
            },

            new Aporte{
                AporteId = 2,
                Fecha = DateTime.Today,
                PersonaId =2,
                Concepto = "Reparacion Techo",
                Monto = 500
            }
        );

        modelBuilder.Entity<Personas>().HasData(
            new Personas{
                Id = 1,
                name = "Nay"
            },

            new Personas{
                Id = 2,
                name = "Jasson"
            }
        );

        modelBuilder.Entity<TiposAportes>().HasData(
            new TiposAportes{
                TipoAporteId = 1,
                Descripcion = "Pintura Banco",
                Meta = 10000,
                Logrado = 5000
            },

            new TiposAportes{
                TipoAporteId = 2,
                Descripcion = "Reparacion Techo",
                Meta = 50000,
                Logrado = 10000
            }
        );
    }
    public DbSet<Aporte> Aporte { get; set; }
    public DbSet<Personas> Personas { get; set; }
    public DbSet<TiposAportes> TiposAportes { get; set; }
}