using LavaCar.LavaCarConsole.DAO;
using LavaCar.LavaCarConsole.Model;
using LavaCar.LavaCarConsole.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar.LavaCarConsole.View
{
    class CadastrarCarro
    {

        public static void Renderizar()
        {
            Carro Carro = new Carro();
            Console.WriteLine("Digite a Placa: ");
            Carro.Placa = Console.ReadLine();
            Console.WriteLine("Digite o Nome: ");
            Carro.Nome = Console.ReadLine();
            if (CarroDAO.AdicionarCarro(Carro))
            {
                Console.WriteLine(Mensagens.CadastroCarroSucesso(Carro));
            }

        }
    }
}
