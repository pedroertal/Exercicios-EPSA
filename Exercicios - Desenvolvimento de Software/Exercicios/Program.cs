using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicios exe = new Exercicios();

            int escolha;
            Console.WriteLine("Qual exercicio você quer executar? \n[1] Exercicio 3 \n[2] Exercício 4\n[0] Cancelar app");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:
                    break;
                case 1:
                    exe.Exercicio3();
                    break;
                case 2:
                    exe.Exercicio4();
                    break;

                default:
                    Console.WriteLine("Número incorreto!");
                    break;
            }
            
        }
    }
}
