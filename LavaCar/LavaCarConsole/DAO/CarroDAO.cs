using LavaCar.LavaCarConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar.LavaCarConsole.DAO
{
    class CarroDAO
    {
        public static List<Carro> ListaDeTodosOsCarros = new List<Carro>();

        public static bool AdicionarCarro(Carro carro)
        {
            ListaDeTodosOsCarros.Add(carro);
            return true;
        }
    }
}
