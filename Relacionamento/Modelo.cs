using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamento
{
    public class Modelo
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Carro> Carros { get; set; }
        public void Salvar()
        {
            var db = new BaseContext();
            db.Modelos.Add(this);
            db.SaveChanges();
        }

        public static List<Modelo> Todos()
        {
            var db = new BaseContext();
            return db.Modelos.ToList();
        }
    }
    
}
