using System.Collections;
using static System.Console;

namespace HelloWorld
{
    class Filas
    {
        public void Fila(string[] args)
        {

            Queue fila = new Queue();
            fila.Enqueue("Gilson");
            fila.Enqueue("Amanda");
            fila.Enqueue("Tony Stark");
            fila.Enqueue("Vand");

            WriteLine(fila.Peek());


            WriteLine($"A fila tem {fila.Count} itens.");


            WriteLine($"o item {fila.Dequeue()} foi retirado");
            WriteLine($"A fila tem {fila.Count} itens.");

            WriteLine($"o item {fila.Dequeue()} foi retirado");
            WriteLine($"A fila tem {fila.Count} itens.");

            WriteLine($"o item {fila.Dequeue()} foi retirado");
            WriteLine($"A fila tem {fila.Count} itens.");

            WriteLine($"o item {fila.Dequeue()} foi retirado");
            WriteLine($"A fila tem {fila.Count} itens.");




            ReadKey();
        }

    }
}
