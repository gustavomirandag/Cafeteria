using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbooks.Modelo
{
    public class CafeExpresso : IBebida
    {
        public string PrepararBebida()
        {
            return "Seu café expresso está pronto!";
        }
    }
}
