using Microsoft.EntityFrameworkCore;
using MS_Clients.Infraestructure.Entity;

namespace MS_Clients.Infraestructure;

public class ClientDbContext  : DbContext
{
    public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
    {
        
    }
    public DbSet<Client> Clients { get; set; }
}