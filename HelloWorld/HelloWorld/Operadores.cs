﻿using static System.Console;

namespace HelloWorld
{
    class Operadores
    {
        public void Operador()
        {
            var x = 10;
            var y = 5;
            var soma = x + y;
            var subtrair = x - y;
            var multiplicar = x * y;
            var dividir = x / y;
            var resto = 7 % 3;



            //soma = soma + subtrair;
            soma += subtrair;
            soma -= subtrair;
            soma *= subtrair;
            soma /= subtrair;
            soma %= subtrair;



            WriteLine(soma);
            WriteLine(subtrair);
            WriteLine(multiplicar);
            WriteLine(dividir);
            WriteLine(resto);

            var i = 1;
            i++;
            i--;

            ++i;
            --i;

            ReadKey();

        }

    }
}
