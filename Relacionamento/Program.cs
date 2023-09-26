using System;
using System.Linq;

namespace Relacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carros = Carro.Todos();
            //var modelos = Modelo.Todos();
            //new Modelo() { Nome = "Xt0358" }.Salvar();
            //new Carro() { Nome = "Etza",Modelo =  Modelo.Todos().First(), Ano = 2019}.Salvar();
        }
    }
}
