using System.ComponentModel.Design;

namespace ATV3_CJ3022625
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n;

            Console.WriteLine("Digite a nota média do aluno: ");
            n = float.Parse(Console.ReadLine());

            if (n >= 6)
            {
                Console.WriteLine("Aluno aprovado");


            }
            else Console.WriteLine("Aluno reprovado");
        }
    }
}
