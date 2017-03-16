using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starbooks.Modelo;

namespace Starbooks.Controle
{
    /// <summary>
    /// Funções Extras para a Máquina de Bebida
    /// </summary>
    public static class ModuladorMaquinaDeBebida
    {
        public static string AdicionarLeite(this MaquinaDeBebida bebida, int quantidade)
        {
            return "Leite adicionado a bebida! Quantidade de litros: " + quantidade;
        }

        public static string AdicionarAcucar(this MaquinaDeBebida bebida)
        {
            return "Açucar adicionado a bebida!";
        }

        public static string AdicionarGelo(this MaquinaDeBebida bebida)
        {
            return "Gelo adicionado a bebida!";
        }

        public static string SayHello(this string str)
        {
            return "Hello!";
        }


    }
}
