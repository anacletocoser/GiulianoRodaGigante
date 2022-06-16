using System;

namespace RodaGigante
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante(); // Criando nova roda gigante
            Adulto paulo = new Adulto("Paulo", 42); //Adulto com o nome Paulo
            // Filhos de Paulo
            Crianca joao = new Crianca("Joao", 5, paulo); //Nova criança cujo pai é Paulo
            Crianca maria = new Crianca("Maria", 12, paulo); // Esta é a filha de Paulo

            //Criança sem pai definido
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            roda.Embarcar(2, joao, maria);
            roda.Embarcar(2, joao, paulo);
            roda.Embarcar(3, maria);
            roda.Embarcar(13, pedro);
            roda.Embarcar(16, henrique);

            roda.status();

            Console.ReadKey();
        }
    }
}
