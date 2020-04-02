
using static System.Console;

namespace HelloWorld
{
    class Whiles
    {
        public void While(string[] args)
        {
            string[] nomes = new string[] { "Vand", "Amanda", "VInicius" };
            int i = 11;
            /*     while(i <= nomes.Length)
             {
                 WriteLine($"Olá {nomes[i]}");
                 i++;
             }*/

            do
            {
                WriteLine($"Num=> {i}");
                i++;
            } while (i <= 10);
            {

            }


            /*int i = 0;

            while (i <= 10)
            {
                WriteLine($"Num=> {i}");
                i++;
            }*/


            ReadKey();
        }
    }
}
