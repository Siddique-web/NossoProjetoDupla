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
                //Exercicio 1
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
                //Exercicio 2
                

            class Programa
            {
                static void Main()
                {
                    Console.WriteLine("=== Cálculo de Soma e Média ===");

                    int quantidade;
                    List<decimal> numeros = new List<decimal>();

                    // Solicitar quantidade de números (entre 3 e 10)
                    while (true)
                    {
                        Console.Write("Informe a quantidade de números (entre 3 e 10): ");
                        if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 3 && quantidade <= 10)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Quantidade inválida! Digite um número inteiro entre 3 e 10.");
                        }
                    }

                    // Solicitar os números
                    for (int i = 0; i < quantidade; i++)
                    {
                        decimal valor;
                        while (true)
                        {
                            Console.Write($"Digite o {i + 1}º número: ");
                            if (decimal.TryParse(Console.ReadLine(), out valor))
                            {
                                numeros.Add(valor);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido! Digite um número válido (pode ser decimal, positivo ou negativo).");
                            }
                        }
                    }

                    // Usando System.Linq para calcular soma e média
                    decimal soma = numeros.Sum();
                    decimal media = numeros.Average();

                    // Resultado
                    Console.WriteLine("\n=== Resultados ===");
                    Console.WriteLine($"Soma: {soma}");
                    Console.WriteLine($"Média: {media}");

                    //Novos exercicios
                   

                class NovoPrograma
                {
                    // Método que soma 5 inteiros e retorna via parâmetros out
                    public static bool AddInts(out int soma)
                    {
                        soma = 0;

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.Write($"Digite o {i}º número inteiro: ");
                            if (int.TryParse(Console.ReadLine(), out int valor))
                            {
                                soma += valor;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Operação cancelada.");
                                return false; // Falha na leitura
                            }
                        }

                        return true; // Sucesso
                    }

                    static void Main()
                    {
                        if (AddInts(out int resultado))
                        {
                            Console.WriteLine($" Soma bem-sucedida! Resultado = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao ler os números. Tente novamente.");
                        }
                    }
                }

            }
        }

        }
    }

    }
}
}
