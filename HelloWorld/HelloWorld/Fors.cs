
using static System.Console;

namespace HelloWorld
{
    class Fors
    {
        public void For(string[] args)
        {
            string[] nomes = new string[] { "Vand", "Amanda", "VInicius" };

            for (int i = 0; i < nomes.Length; i++)
            {
                WriteLine($"Olá {nomes[i]}");
            }



            /*for (int i = 0; i <= 10; i++)
            {
                WriteLine($"Num => {i}");
            }*/


            ReadKey();
        }
    }
}
