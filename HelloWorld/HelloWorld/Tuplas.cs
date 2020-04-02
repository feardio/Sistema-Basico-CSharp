using System.Collections;
using static System.Console;

namespace HelloWorld
{
    class Tuplas
    {
        public void Tupla(string[] args)
        {
            //var pares = System.Tuple.Create(2, 4, 6, 8. 10);
            // pares.Item;

            // (string, string, double) brasil = ("Brasil", "Brasilia", 1268.33);
            // WriteLine($"O {brasil.Item1}, cuja sua capital é {brasil.Item2} tem a rpc de R${brasil.Item3}");

            (string nome, string tipoGoverno, int populacao, string capital, double rpc) brasil = ("Brasil", "Presidencialismo", 200, "Brasilia", 1268.33);
            WriteLine($"O {brasil.nome}, cuja sua capital é {brasil.capital} tem a rcp de R${brasil.rpc} e a população de {brasil.populacao} milhões");

            ReadKey();
        }
    }
}
