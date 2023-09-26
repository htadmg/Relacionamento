using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("RelationshipArtesanal") { }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Carro> Carros{ get; set; }
    }
}
