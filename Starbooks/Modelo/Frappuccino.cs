using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbooks.Modelo
{
    public class Frappuccino : IBebida
    {
        public string PrepararBebida()
        {
            return "Frappuccino preparado!";
        }
    }
}
