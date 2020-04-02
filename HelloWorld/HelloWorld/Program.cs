using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            /* string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            foreach (string dia in diasSemanas)
            {
                WriteLine($"Hoje é {dia}");
            }
            */
            /* Queue fila = new Queue();
             fila.Enqueue("Gilson");
             fila.Enqueue("Amanda");
             fila.Enqueue("Vand");
             fila.Enqueue("Vinicius");

             foreach(string nome in fila)
             {
                 WriteLine($"Nome -> {nome}");
             }
             */

            Stack<int> p1 = new Stack<int>();

            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);

            foreach(int num in p1)
            {
                WriteLine($"Numero {num}");
            }

        

            ReadKey();
        }
    }
}
