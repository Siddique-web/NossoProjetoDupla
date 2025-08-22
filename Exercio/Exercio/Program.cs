using System;
using System.Collections.Generic;

namespace Exercio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU PRINCIPAL ===");
                Console.WriteLine("1 - Calculadora");
                Console.WriteLine("2 - Soma e Média");
                Console.WriteLine("3 - Soma com parâmetro out");
                Console.WriteLine("4 - Controle do Drone"); // Opção 4
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                    Console.ReadLine();
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        Calculadora.Executar();
                        break;
                    case 2:
                        ProgramaSomaMedia.Executar();
                        break;
                    case 3:
                        NovoPrograma.Executar();
                        break;
                    case 4:
                        ExercicioDrone.Executar(); // Agora reconhece 4
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para continuar...");
                        Console.ReadLine();
                        break;
                }


            } while (opcao != 0);
        }
    }

    // ================== EXERCÍCIO 1 ==================
    class Calculadora
    {
        public static void Executar()
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
                Console.WriteLine("0 - Voltar ao Menu Principal");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Pressione Enter...");
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
                        case 1: Console.WriteLine($"Resultado: {valor1 + valor2}"); break;
                        case 2: Console.WriteLine($"Resultado: {valor1 - valor2}"); break;
                        case 3: Console.WriteLine($"Resultado: {valor1 * valor2}"); break;
                        case 4:
                            if (valor2 == 0) Console.WriteLine("Não é possível dividir por zero.");
                            else Console.WriteLine($"Resultado: {valor1 / valor2}");
                            break;
                        case 5:
                            if (valor2 == 0) Console.WriteLine("Não é possível dividir por zero.");
                            else Console.WriteLine($"Resto da divisão: {valor1 % valor2}");
                            break;
                        case 6:
                            Console.WriteLine($"Resultado da potenciação: {Math.Pow(valor1, valor2)}");
                            break;
                    }

                    Console.WriteLine("Pressione Enter...");
                    Console.ReadLine();
                }

            } while (opcao != 0);
        }
    }

    // ================== EXERCÍCIO 2 ==================
    class ProgramaSomaMedia
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Cálculo de Soma e Média ===");

            int quantidade;
            List<decimal> numeros = new List<decimal>();

            while (true)
            {
                Console.Write("Informe a quantidade de números (entre 3 e 10): ");
                if (int.TryParse(Console.ReadLine(), out quantidade) && quantidade >= 3 && quantidade <= 10)
                    break;
                Console.WriteLine("Quantidade inválida! Digite um número entre 3 e 10.");
            }

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
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }
            }

            decimal soma = 0;
            foreach (var n in numeros) soma += n;
            decimal media = soma / numeros.Count;

            Console.WriteLine($"\nSoma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine("Pressione Enter...");
            Console.ReadLine();
        }
    }

    // ================== EXERCÍCIO 3 ==================
    class NovoPrograma
    {
        public static bool AddInts(out int soma)
        {
            soma = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}º número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int valor)) soma += valor;
                else { Console.WriteLine("Entrada inválida!"); return false; }
            }
            return true;
        }

        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Soma com parâmetro out ===");
            if (AddInts(out int resultado)) Console.WriteLine($"Resultado = {resultado}");
            else Console.WriteLine("Erro ao ler números.");
            Console.WriteLine("Pressione Enter...");
            Console.ReadLine();
        }
    }

    // ================== EXERCÍCIO 4 ==================
    class ExercicioDrone
    {
        public static void Executar()
        {
            Drone drone = new Drone();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Controle do Drone ===");
                Console.WriteLine("1 - Definir altura");
                Console.WriteLine("2 - Subir/Descer 0,5m");
                Console.WriteLine("3 - Definir direção");
                Console.WriteLine("4 - Girar direção 5º esquerda/direita");
                Console.WriteLine("5 - Ajustar velocidade 0,5 m/s");
                Console.WriteLine("6 - Aproximar objeto");
                Console.WriteLine("7 - Distanciar de objeto");
                Console.WriteLine("8 - Mostrar status dos braços");
                Console.WriteLine("0 - Voltar ao menu");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao)) continue;

                switch (opcao)
                {
                    case 1: drone.DefinirAltura(); break;
                    case 2: drone.AjustarAlturaProgressiva(); break;
                    case 3: drone.DefinirDirecao(); break;
                    case 4: drone.GirarDirecaoProgressiva(); break;
                    case 5: drone.AjustarVelocidade(); break;
                    case 6: drone.AproximarObjeto(); break;
                    case 7: drone.DistanciarObjeto(); break;
                    case 8: drone.MostrarStatusBracos(); break;
                    case 0: break;
                    default: Console.WriteLine("Opção inválida!"); break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("Pressione Enter...");
                    Console.ReadLine();
                }

            } while (opcao != 0);
        }
    }

    class Drone
    {
        private double altura = 0.5;
        private int direcao = 0;
        private double velocidade = 0;
        private bool proximoObjeto = false;

        private Braco bracoEsquerdo = new Braco("Esquerdo");
        private Braco bracoDireito = new Braco("Direito");

        public void DefinirAltura()
        {
            if (proximoObjeto) { Console.WriteLine("Próximo de objeto! Não pode alterar altura."); return; }
            Console.Write("Informe altura (0,5 a 25 m): ");
            if (!double.TryParse(Console.ReadLine(), out double h)) { Console.WriteLine("Valor inválido!"); return; }
            if (h < 0.5 || h > 25) Console.WriteLine("Altura fora do limite!");
            else { altura = h; Console.WriteLine($"Altura = {altura} m"); }
        }

        public void AjustarAlturaProgressiva()
        {
            if (proximoObjeto) { Console.WriteLine("Próximo de objeto! Não pode alterar altura."); return; }
            Console.WriteLine("Digite + para subir 0,5m ou - para descer 0,5m:");
            string s = Console.ReadLine();
            if (s == "+") altura = altura + 0.5 > 25 ? 25 : altura + 0.5;
            else if (s == "-") altura = altura - 0.5 < 0.5 ? 0.5 : altura - 0.5;
            Console.WriteLine($"Altura atual = {altura} m");
        }

        public void DefinirDirecao()
        {
            if (proximoObjeto) { Console.WriteLine("Próximo de objeto! Não pode alterar direção."); return; }
            Console.Write("Informe direção (0-360): ");
            if (!int.TryParse(Console.ReadLine(), out int d)) { Console.WriteLine("Valor inválido!"); return; }
            direcao = ((d % 360) + 360) % 360;
            Console.WriteLine($"Direção = {direcao}º");
        }

        public void GirarDirecaoProgressiva()
        {
            if (proximoObjeto) { Console.WriteLine("Próximo de objeto! Não pode alterar direção."); return; }
            Console.WriteLine("L = esquerda 5º, R = direita 5º:");
            string s = Console.ReadLine().ToUpper();
            if (s == "L") direcao = (direcao - 5 + 360) % 360;
            else if (s == "R") direcao = (direcao + 5) % 360;
            Console.WriteLine($"Direção atual = {direcao}º");
        }

        public void AjustarVelocidade()
        {
            Console.WriteLine("Digite + para aumentar 0,5 m/s, - para diminuir 0,5 m/s:");
            string s = Console.ReadLine();
            if (s == "+") velocidade = velocidade + 0.5 > 15 ? 15 : velocidade + 0.5;
            else if (s == "-") velocidade = velocidade - 0.5 < 0 ? 0 : velocidade - 0.5;
            Console.WriteLine($"Velocidade atual = {velocidade} m/s");
        }

        public void AproximarObjeto()
        {
            if (velocidade != 0) { Console.WriteLine("Drone precisa estar parado!"); return; }
            proximoObjeto = true;
            Console.WriteLine("Drone aproximado ao objeto.");
        }

        public void DistanciarObjeto()
        {
            if (!proximoObjeto) { Console.WriteLine("Drone não está próximo de objeto!"); return; }
            proximoObjeto = false;
            Console.WriteLine("Drone se afastou do objeto.");
        }

        public void MostrarStatusBracos()
        {
            bracoEsquerdo.MostrarStatus();
            bracoDireito.MostrarStatus();
        }
    }

    class Braco
    {
        private string nome;
        private string estado = "Repouso";

        public Braco(string nome) { this.nome = nome; }
        public void MostrarStatus() => Console.WriteLine($"Braço {nome}: Estado = {estado}");
    }
}
