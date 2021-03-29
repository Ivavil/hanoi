using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Introduce el número de elementos");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i > 0) { 
                List<Disco> lista = new List<Disco>();
                for(int n = i; n >= 1; n--)
                {
                    lista.Add(new Disco(n));
                }
       
                Pila INI = new Pila(i, lista[i - 1].Valor, lista, "ini");
                Pila AUX = new Pila("aux");
                Pila FIN = new Pila("fin");

                Hanoi hanoi = new Hanoi();
                int res = hanoi.iterativo(i, INI, FIN, AUX);
                Console.WriteLine(res);
               
                
            } else
            {
                Console.WriteLine("Por favor, introduzca una cantidad de discos mayor que 0");
            }
        }
    }
}
