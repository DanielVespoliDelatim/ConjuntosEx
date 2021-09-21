using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Exfix4 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();


            Console.Write("o curso A possui quantos alunos? ");
            int alunosA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A: "); ;
            for (int i = 0; i < alunosA; i++) {
                int x = int.Parse(Console.ReadLine());
                A.Add(x);

            }

            Console.Write("o curso B possui quantos alunos? ");
            int alunosB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B: "); ;
            for (int i = 0; i < alunosB; i++) {
                int x = int.Parse(Console.ReadLine());
                B.Add(x);

            }

            Console.Write("o curso C possui quantos alunos? ");
            int alunosC = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C: "); ;
            for (int i = 0; i < alunosC; i++) {
                int x = int.Parse(Console.ReadLine());
                C.Add(x);

            }


            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine("Total de alunos: " + A.Count()); 

            

            
                








        }
    }
}
