using NewFilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace NewFilmesAPI.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
