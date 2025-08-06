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
            int n1, n2, soma;
            Console.WriteLine("Digite o primeiro nr");
            n1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo nr");
            n2=Int32.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma destes dois nrs é" + soma);
        }
    }
}
