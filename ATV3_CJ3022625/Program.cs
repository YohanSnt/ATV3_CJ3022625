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
                Console.WriteLine("Aluno aprovado\n");


            }
            else Console.WriteLine("Aluno reprovado\n");

            //ATV1
            int nm;

            Console.WriteLine("1- Digite um número: ");
            nm = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Número é PAR");
            }
            else Console.WriteLine("Número é ÍMPAR");

            //ATV2
            float md1, md2, md3, tr;
            Console.WriteLine("\n 2- Digite a medida de um lado do triângulo: ");
            md1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida do outro lado: ");
            md2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Medida do terceiro lado: ");
            md3 = float.Parse(Console.ReadLine());

            if ((md1 == md2) && (md2 == md3))
            {
                Console.WriteLine("Triângulo equilátero\n");


            }
            else if ((md1 == md2) && (md1 != md3) || (md2 == md3) && (md2 != md1) || (md3 == md1) && (md3 != md2))
            {
                Console.WriteLine("Triângulo isóceles\n");

            }
            else if ((md1 != md2) && (md2 != md3))
            {
                Console.WriteLine("Triângulo escaleno\n");
            }

            //ATV3


            //ATV4
            string nome, senha;
            Console.WriteLine("\n4- Nome de usuário: ");
            nome = Console.ReadLine();
            Console.WriteLine("\nSenha: ");
            senha = Console.ReadLine();

            if ((nome == "admin") && (senha == "admin123"))
            {
                Console.WriteLine("Acesso concedido");
            }
            else Console.WriteLine("Acesso negado");

            //ATV5
            int nu;
            Console.WriteLine("Digite um´número de 0-100: ");
            nu = int.Parse(Console.ReadLine());

            if ((nu >= 90) && (nu <= 100))
            {
                Console.WriteLine("Classe A");

            }
            else if ((nu >= 80) && (nu <= 89))
            {
                Console.WriteLine("Classe B");
            }

        }
    }
}
