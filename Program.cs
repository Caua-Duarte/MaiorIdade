using System;

namespace MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();
            Console.WriteLine("Pessoa com maior idade");
            //Primeira pessoa
            Console.Write("Nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade da primeira pessoa: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());
            //Segunda pessoa
            Console.Write("Nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade da segunda pessoa: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());
            //Primeira pessoa
            Console.Write("Nome da terceira pessoa: ");
            p3.Nome = Console.ReadLine();
            Console.Write("Idade da terceira pessoa: ");
            p3.Idade = Convert.ToInt32(Console.ReadLine());

            //Lógica
            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }
            else if ((p2.Idade > p3.Idade) && (p2.Idade > p1.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }
            else if ((p3.Idade > p2.Idade) && (p3.Idade > p1.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            else
            {
                Console.WriteLine("Todas as pessoas possuem a mesma idade!");
            }
        }
    }
}
