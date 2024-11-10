using Microsoft.EntityFrameworkCore;

public class Contexto : DbContext
{
    public DbSet<Detenciones> Detenciones { get; set; }

    public Contexto ( DbContextOptions < Contexto > options ): base( options ){ }
}
