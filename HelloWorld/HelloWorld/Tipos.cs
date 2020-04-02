using static System.Console;

namespace HelloWorld
{
    class Tipos
    {
        public void Tipo()
        {
            // char status = "Á";
            // byte = 0 as 255;
            // sbyte = -128 as 127;
            // short -32768 a 32768;
            // ushort 0 a 65535
            // int = negativo ao positivo
            //uint = apenas 0 as postivo
            // decimal temperatura = 30.2m;
            // double temperatura =30.5;
            // float temperatura = 30.3f;
            // bool true ou false;
            /*
            char status = "A";
            int idade = 20;
            string nome = "Vinicius";
            WriteLine(nome.GetType().IsPrimitive);
            ReadKey();
            */

            int n1 = 10;
            //long n2 = n1;
            short n2 = (short)n1;

            WriteLine(n2);
            ReadKey();

        }

    }
}
