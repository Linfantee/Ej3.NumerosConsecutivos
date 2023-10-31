using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.NumerosConsecutivos.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNumero() 
        {
            int valor;

            Console.WriteLine("Dame un número");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor; 
        }

    }
}
