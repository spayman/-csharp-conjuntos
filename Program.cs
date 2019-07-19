using System;
using System.Collections.Generic;

namespace Exercicio_05_Conjunto
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();


            // Dados do curso A
            Console.Write("O curso A possui quantos alunos?: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= a; i++)
            {
                Console.Write("Digite o código do {0}ª aluno: ", i);
                int vl = int.Parse(Console.ReadLine());
                A.Add(vl);
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // Dados do curso B
            Console.Write("O curso B possui quantos alunos?: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= b; i++)
            {
                Console.Write("Digite o código do {0}ª aluno: ", i);
                int vl = int.Parse(Console.ReadLine());
                B.Add(vl);
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            // Dados do curso B
            Console.Write("O curso C possui quantos alunos?: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= c; i++)
            {
                Console.Write("Digite o código do {0}ª aluno: ", i);
                int vl = int.Parse(Console.ReadLine());
                C.Add(vl);
            }

            Console.WriteLine();   
            HashSet<int> tot = new HashSet<int>();

            tot.UnionWith(A);
            tot.UnionWith(B);
            tot.UnionWith(C);

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("O instrutor Joaquim tem um total de {0} alunos", tot.Count);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");





        }
    }
}
