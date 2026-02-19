using Microsoft.EntityFrameworkCore;

namespace desafio_paises.Models;

public class CriarContextoDb : DbContext
{
    public CriarContextoDb(DbContextOptions<CriarContextoDb> options)
        : base(options)
    {
    }

    public DbSet<Pais> Paises { get; set; } // Cria tabela SQLite baseado na Classe "Pais.cs
}