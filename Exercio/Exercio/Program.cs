using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using System;

class Calculadora
        {
            static void Main()
            {
                int opcao;

                do
                {
                    Console.Clear();
                    Console.WriteLine("=== CALCULADORA ===");
                    Console.WriteLine("1 - Somar");
                    Console.WriteLine("2 - Subtrair");
                    Console.WriteLine("3 - Multiplicar");
                    Console.WriteLine("4 - Dividir");
                    Console.WriteLine("5 - Resto da Divisão");
                    Console.WriteLine("6 - Potenciação");
                    Console.WriteLine("0 - Sair");
                    Console.Write("Escolha uma opção: ");

                    if (!int.TryParse(Console.ReadLine(), out opcao))
                    {
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                        Console.ReadLine();
                        continue;
                    }

                    if (opcao >= 1 && opcao <= 6)
                    {
                        Console.Write("Digite o primeiro valor: ");
                        double valor1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo valor: ");
                        double valor2 = double.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine($"Resultado: {valor1 + valor2}");
                                break;

                            case 2:
                                Console.WriteLine($"Resultado: {valor1 - valor2}");
                                break;

                            case 3:
                                Console.WriteLine($"Resultado: {valor1 * valor2}");
                                break;

                            case 4:
                                if (valor2 == 0)
                                {
                                    Console.WriteLine("Não é possível dividir por zero.");
                                }
                                else
                                {
                                    Console.WriteLine($"Resultado: {valor1 / valor2}");
                                }
                                break;

                            case 5:
                                if (valor2 == 0)
                                {
                                    Console.WriteLine("Não é possível dividir por zero.");
                                }
                                else
                                {
                                    Console.WriteLine($"Resto da divisão: {valor1 % valor2}");
                                }
                                break;

                            case 6:
                                double resultadoPotencia = Math.Pow(valor1, valor2);
                                Console.WriteLine($"Resultado da potenciação: {resultadoPotencia}");
                                break;
                        }

                        Console.WriteLine("Pressione Enter para voltar ao menu...");
                        Console.ReadLine();
                    }
                    else if (opcao != 0)
                    {
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                        Console.ReadLine();
                    }

                } while (opcao != 0);

                Console.WriteLine("Programa encerrado.");
            }
        }

    }
}
}
