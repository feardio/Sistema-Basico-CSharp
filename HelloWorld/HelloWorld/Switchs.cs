using System;
using static System.Console;

namespace HelloWorld
{
    class Switchs
    {
        public void Switch(string[] args)
        {
            Write("Infomre o saldo do cartao/banco: ");
            var eSaldo = Convert.ToDouble(ReadLine());

            Write("Infomre o valor da compra: ");
            var eValor = Convert.ToDouble(ReadLine());

            Write("Infomre o tipo de pagamento(C para credito, D para debito e qualquer outra letra para dinheiro): ");
            char eTipo = Convert.ToChar(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com Cartão de credito não aprovada!");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com Cartão de debito não aprovada!");
                    break;
                default:
                    WriteLine("Compra aprovada!");
                    break;
            }


            /*  switch (eTipo)
              {
                  case 'C':
                      WriteLine("Compra com Cartão de credito");
                      break;
                  case 'D':
                      WriteLine("Compra com Cartão de Debito");
                      break;
                  default:
                      WriteLine("Compra com Dinheiro");
                      break;
              }
              */

            ReadKey();
        }
    }
}
