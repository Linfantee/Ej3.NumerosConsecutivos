using Ej3.NumerosConsecutivos.Servicios;

namespace Ej3.NumerosComsecutivos 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            //Variables
            int valor;
            string num;

            //Creacion de objetos
            MenuInterfaz m1 = new MenuImplementacion();
            MenuInterfaz2 m2 = new MenuImplementacion2();

            //Guardamos el valor a traves de los metodos
            valor = m1.pedirNumero();
            num = m2.Operacion(valor);
        }

    }

}
