using System;
using static System.Console;

namespace HelloWorld
{
    class Estruturas_decisoes
    {
        public void Decisoes(string[] args)
        {

            double salario = 0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;

            Write("Informe seu salario: ");
            salario = Convert.ToDouble(ReadLine());

            Write("Informe seus Gastos Mensais: ");
            gastosMensais = Convert.ToDouble(ReadLine());

            Write("Tem decimo Terceiro? ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if (temDecimoTerceiro)
            {
                salario += salario;
            }


            if (gastosMensais > salario)
            {
                WriteLine("Você precisa economizar!");
            }
            else if (gastosMensais == salario)
            {
                WriteLine("Você está com 0 reais de saldo!");
            }
            else
            {
                WriteLine("Legal! Soubrou dinheiro esse mês!");
            }

            ReadKey();
        }
    }
}
