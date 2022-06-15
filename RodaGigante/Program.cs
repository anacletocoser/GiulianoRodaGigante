using System;

namespace RodaGigante
{
    class Program
    {
        static void Main(string[] args)
        {
            RodaGigante roda = new RodaGigante();// Criando a roda gigante

            Adulto paulo = new Adulto("Paulo", 42);//Adulto com o nome Paulo

            
            //Filhos do Paulo
            Crianca joao = new Crianca("João", 5, paulo);
            Crianca maria = new Crianca("Maria", 12, paulo);

            

            //Criança sem pai definido
            Crianca pedro = new Crianca("Pedro", 13);
            Crianca henrique = new Crianca("Henrique", 10);

            //Gondola gondola = new Gondola();

            //gondola.Assento1 = paulo;

            //gondola.Assento2 = joao;
            
            
            roda.Embarcar(2,joao, paulo);
            roda.Embarcar(3,pedro, henrique);

            roda.status();

            

            //Console.WriteLine(gondola.Assento2);
            // Matriz é um arranjo bidimensional

            //            string[,] x = new string[3, 3];

            //            x[0,0] = "1";
            //            x[0,1] = "Pedro";
            //            x[0,2] = "José";
            //            x[1,0] = "2";
            //            x[1, 1] = "";
            //            x[1, 2] = "";
            //            x[2, 0] = "3";
            //            x[2, 1] = "";
            //            x[2, 2] = "";
            //;            //Console.WriteLine(x);
            //for (int linha = 0; linha < 3; linha++)
            //{
            //    for (int coluna = 0; coluna < 3; coluna++)
            //    {
            //        if (coluna == 1)
            //        {
            //            x[linha, coluna] = "Pessoa1";
            //        }
            //        if (coluna == 2)
            //        {
            //            x[linha, coluna] = "Pessoa2";
            //        }
            //        Console.Write(x[linha, coluna] + "  ");
            //    }
            //    Console.WriteLine();
            //}

            //            foreach(string item in x)
            //            {
            //                Console.Write(item);
            //            }
            //            Console.WriteLine();
            //            //string nome = "Giuliano";
            //            //string sobrenome = "Lovera Fernandes";
            //            //string nomeCompleto = nome + " " + sobrenome;
            //            //Console.WriteLine(nomeCompleto);

            //            string nomeUsuario = "Giuliano";

            Console.ReadKey();
        }
    }
}
