using aplicacao_fotos.Data.DBmodels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace aplicacao_fotos.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Categorias> Categorias { get; set; }
    public DbSet<Compras> Compras { get; set; }
    public DbSet<Fotografias> Fotografias { get; set; }
    public DbSet<Gostos> Gostos { get; set; }
    public DbSet<Utilizadores> Utilizadores { get; set; }
    
}