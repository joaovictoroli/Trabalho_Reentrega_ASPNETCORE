using Microsoft.EntityFrameworkCore;
using Trabalho_Reentrega_ASPNETCORE.Models;

namespace Trabalho_Reentrega_ASPNETCORE.Data
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {

        }
        public  DbSet<Pessoa> Pessoas { get; set; }
    }
}
