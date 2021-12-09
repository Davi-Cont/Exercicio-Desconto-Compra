using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da venda:");
            double vlr_venda = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a forma de pagamento:" +
                                "\n DI = Dinheiro" +
                                 "\n CA = Cartão" +
                                  "\n CH = Cheque");
            string pagamento = Console.ReadLine().ToUpper();

            if(pagamento == "DI")
            {
                double desconto = vlr_venda * 10 / 100;
                Console.WriteLine("Voce tem 10% de desconto");
                Console.WriteLine("O valor do desconto é de: " + desconto.ToString("C"));
                double vlr_com_desc = vlr_venda - desconto;
                Console.WriteLine("O valor total da compra é de: " + vlr_com_desc.ToString("C"));

            }

            else if (pagamento == "CA")
            {
                double desconto = vlr_venda * 7.5 / 100;
                Console.WriteLine("Voce tem 7,5% de desconto");
                Console.WriteLine("O valor do desconto é de: " + desconto.ToString("C"));
                double vlr_com_desc = vlr_venda - desconto;
                Console.WriteLine("O valor total da compra é de: " + vlr_com_desc.ToString("C"));

            }

            else if (pagamento == "CH")
            {
                double desconto = vlr_venda * 5 / 100;
                Console.WriteLine("Voce tem 5% de desconto");
                Console.WriteLine("O valor do desconto é de: " + desconto.ToString("C"));
                double vlr_com_desc = vlr_venda - desconto;
                Console.WriteLine("O valor total da compra é de: " + vlr_com_desc.ToString("C"));

            }

            else 
            {
                Console.WriteLine("Forma de pagamento invalida !!");
            }

            Console.ReadKey();







        }
    }
}
