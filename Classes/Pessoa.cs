using System;

namespace MaiorIdade
{
    public class Pessoa
    {
        //Construores
        public Pessoa()
        {
            this.Nome = "" ;
            this.Idade = 0 ;
        }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        
        //Propriedades
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }

        private int idade;
        public int Idade
        {
            get { return this.idade; }
            set 
            { 
                if(value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0; 
                }
            }
        }
        
        
        //Métodos
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
        
    }
}