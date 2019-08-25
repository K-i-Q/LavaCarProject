using LavaCar.LavaCarConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaCar.LavaCarConsole.Util
{
    class Mensagens
    {
        public static string CadastroCarroSucesso(Carro Carro)
        {
            return "Carro " + Carro.Nome + " com placa " + Carro.Placa + " cadastrado com sucesso";
        }
    }
}
