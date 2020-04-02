using static System.Console;

namespace HelloWorld
{
    class Variaveis
    {
        public void Variavel()
        {
            int idade = 30;
            string nome = "Vinicius";
            bool ativo = true;
            decimal salario = 1500.54m;
            float descontos = 989.44f;
            var cidade = "Osasco";

            WriteLine($"O usuario {nome} tem {idade} anos de idade, está {ativo} no sistema e ganha R${salario} por mês. Tem desconto de {descontos} e mora em {cidade}.");
            WriteLine("\n -------------------------------------------------------------------------\n");

            dynamic x = "Essa variavel é uma string";
            WriteLine(x);

            x = 10;
            WriteLine(x);

            x = true;
            WriteLine(x);

            ReadKey();

        }
    }
}
