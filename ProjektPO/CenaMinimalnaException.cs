using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO
{
    class CenaMinimalnaException:Exception
    {
        public CenaMinimalnaException()
        {
            Console.WriteLine("Cena produktu musi wynosić co najmniej 5 zł.");
            Console.ReadKey();
        }

        
    }
}
