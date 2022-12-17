using backend.Model;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options){}

        public DbSet<Jogo> Jogos {get; set;}
        public DbSet<Usuario> Usuarios {get; set;}
    }
}