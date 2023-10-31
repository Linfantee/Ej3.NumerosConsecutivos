using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.NumerosConsecutivos.Servicios
{
    internal class MenuImplementacion2 : MenuInterfaz2
    {
        public string Operacion(int valor) 
        {
            string aux="";

            for (int i = 1; i <= valor; i++) 
            {
                aux = aux + i;  
                Console.WriteLine(aux);
            }
            return aux;        
        }        
    }
}
