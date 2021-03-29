using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        public void mover_disco(Pila a, Pila b)
        {
            bool mov_a_b;
            bool mov_b_a;
            if (b.isEmpty() == true)
            {
                mov_b_a = false;
                mov_a_b = true;
                Console.WriteLine("Muevo el disco " + a.Top + " desde " + a.Name + " hasta " + b.Name);
            }
            else if (a.isEmpty() == true)
            {
                mov_a_b = false;
                mov_b_a = true;
                Console.WriteLine("Muevo el disco " + b.Top + " desde " + b.Name + " hasta " + a.Name);
            }
            else if (a.Top < b.Top && b.isEmpty() == false) {
                mov_b_a = false;
                mov_a_b = true;
                Console.WriteLine("Muevo el disco " + a.Top + " desde " + a.Name + " hasta " + b.Name);
            }
            else if (a.Top > b.Top && a.isEmpty() == false) {
                mov_a_b = false;
                mov_b_a = true;
                Console.WriteLine("Muevo el disco " + b.Top + " desde " + b.Name + " hasta " + a.Name);
            }
            else
            {
                mov_b_a = false;
                mov_a_b = false;
                Console.WriteLine("No Puedo mover");
            }

            if(mov_a_b == true && mov_b_a == false)
            {
                b.push(a.Elementos[a.Size - 1]);
                a.pop();
               
            } else if (mov_b_a == true && mov_a_b == false)
            {
                a.push(b.Elementos[b.Size - 1]);
                b.pop();
            }
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            return 0;
        }

    }
}
