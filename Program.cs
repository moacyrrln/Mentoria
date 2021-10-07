using System;

namespace Mentoria
{
    class Program
    {
        static void Main()
        {
            CachorroDeEstimacao MeuCachorro = new CachorroDeEstimacao
            {
                Tem4Patas = false,
                TemPelo = true,
                Nome = "Scooby",
                Endereco = "Endereço da minha casa"
            };

            Console.WriteLine(MeuCachorro.Tem4Patas);
            Console.WriteLine(MeuCachorro.TemPelo);
            Console.WriteLine(MeuCachorro.Nome);
            Console.WriteLine(MeuCachorro.Endereco);
            Console.WriteLine(MeuCachorro.AlimentarSe());
            MeuCachorro.Correr();
            MeuCachorro.Correr(30);

            var Eu = new Pessoa { Nome = "Moacyr", Email="moacyr@gmail.com"};
            Console.WriteLine(Eu.EnviarEmail());

        }
    }

    // Criação de Interface
    interface IAnimal
    {
        public bool Tem4Patas { get; set; }
    }

    // Criação de uma classe abstrata, herdando uma interface
    public abstract class Cachorro : IAnimal
    {
        public bool Tem4Patas { get; set; }
        public bool TemPelo { get; set; }
        public virtual string AlimentarSe()
        {
            return "Alimenta-se de outros animais na natureza";
        }
    }

    public class CachorroDeEstimacao : Cachorro
    {
        public string Endereco;
        public string Nome { get; set; }

        //Polimorfismo
        public override string AlimentarSe()
        {
            //return "Alimenta-se de ração";
            return base.AlimentarSe();
        }

        //Exemplo de sobrecarga
        public void Correr()
        {
            Console.WriteLine("Estou correndo com uma velocidade qualquer");
        }

        public void Correr(int velocidade)
        {
            Console.WriteLine("Estou correndo com uma velocidade de " + velocidade + " km/h");
        }
    }

    public class Pessoa
    {
        public Pessoa()
        {

        }

        public string Nome;
        public string Email;

        public string EnviarEmail()
        {
            return "Enviar email para " + Email;
        }
    }
}
