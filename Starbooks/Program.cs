using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starbooks.Controle;
using Starbooks.Modelo;

namespace Starbooks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Máquina de Café
            CafeExpresso cafe = new CafeExpresso();
            MaquinaDeBebida maquinaDeBebida = new MaquinaDeBebida(cafe);

            string copo = maquinaDeBebida.EncherCopo();
            Console.WriteLine(copo);
            //---------------


            //Usando as Funções Extras do Modulador da Máquina de Bebida
            copo += maquinaDeBebida.AdicionarGelo();
            Console.WriteLine(copo);
            //----------------------------------------------------------

            Console.ReadLine();
        }
    }
}
