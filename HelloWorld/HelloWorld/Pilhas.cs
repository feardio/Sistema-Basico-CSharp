using System.Collections.Generic;
using static System.Console;

namespace HelloWorld
{
    class Pilhas
    {
        public void Pilha(string[] args)
        {
            Stack<int> p1 = new Stack<int>();

            p1.Push(2);
            p1.Push(3);
            p1.Push(5);
            p1.Push(7);
            p1.Push(11);


            WriteLine($"A pilha tem {p1.Count} itens.");
            //WriteLine(p1.ToArray().GetValue(4));
            WriteLine(p1.Peek());
            p1.Pop();

            WriteLine($"A pilha tem {p1.Count} itens.");
            //WriteLine(p1.ToArray().GetValue(3));
            WriteLine(p1.Peek());

            p1.Clear();
            WriteLine($"A pilha tem {p1.Count} itens.");

            ReadKey();
        }

    }
}
