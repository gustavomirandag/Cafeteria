using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starbooks.Modelo;

namespace Starbooks.Controle
{
    public class MaquinaDeBebida
    {
        IBebida bebida;

        public MaquinaDeBebida(IBebida bebida)
        {
            this.bebida = bebida;
        }

        public string EncherCopo()
        {
            return bebida.PrepararBebida();
        }
    }
}
