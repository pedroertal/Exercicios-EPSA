using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Exercicios
    {
        /* Classe do exercício 3 */
        internal class Computador
        {
            public string marca { get; set; }
            public int memoria { get; set; }
            public int monitor { get; set; }
            public double preco { get; set; }

            public Computador(string parametroMarca, int parametroMemoria, int parametroMonitor, double parametroPreco)
            {
                marca = parametroMarca;
                memoria = parametroMemoria;
                monitor = parametroMonitor;
                preco = parametroPreco;
            }
        }

        /* Método do exercício 3 */
        public void Exercicio3()
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("----------Abaixo a lista de computadores disponíveis----------");
            Console.WriteLine("|--Item--|------Marca------|---Memória---|---Monitor---|Valor (R$)|");

            Computador computador1 = new Computador("Notebook Lenovo", 8, 14, 2640);
            Computador computador2 = new Computador("Notebook Samsung", 4, 14, 1980);
            Computador computador3 = new Computador("Notebook Dell", 16, 15, 3229);
            Computador computador4 = new Computador("Notebook Asus", 32, 15, 3519);

            Console.WriteLine("Como você queria ordenar?");
            Console.WriteLine("[1] por memória?");
            Console.WriteLine("[2] por preço?");
            Console.WriteLine("[3] encerrar o programa!");

            int escolha = int.Parse(Console.ReadLine());

            List<Computador> listaComputadores = new List<Computador> { computador1, computador2, computador3, computador4 };

            switch (escolha)
            {
                case 1:
                    listaComputadores.Sort((x, y) => x.preco.CompareTo(y.preco));
                    break;
                case 2:
                    listaComputadores.Sort((x, y) => x.memoria.CompareTo(y.memoria));
                    break;
                case 3:
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                    break;
            }

            // Imprimir os computadores ordenados
            Console.WriteLine("\n--- Computadores ordenados ---");
            Console.WriteLine("|--Item--|------Marca------|---Memória---|---Monitor---|Valor (R$)|");
            foreach (var computador in listaComputadores)
            {
                Console.WriteLine($"|{computador.marca,-9}|{computador.memoria,14}|{computador.monitor,13}|{computador.preco,13}|");
            }
        }

        public void Exercicio4()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i + 1} - Eu não irei utilizar o celular na aula");
            }
        }
    }
}
