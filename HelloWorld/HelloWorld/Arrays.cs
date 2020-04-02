using static System.Console;

namespace HelloWorld
{
    class Arrays
    {
        public void Array(string[] args)
        {
            //int x = 10;
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 15;


            string[] nomes = new string[2];
            nomes[0] = "Vinicius";
            nomes[1] = "Vand";

            WriteLine(x[1]);
            WriteLine(nomes[0]);
            WriteLine(nomes[1]);

            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            WriteLine(diasSemanas[3]);



            ReadKey();

        }

    }
}
