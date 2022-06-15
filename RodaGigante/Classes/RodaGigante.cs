using System;
using System.Collections.Generic;
using System.Text;

namespace RodaGigante
{
    public class RodaGigante
    {
        public List<Gondola> ListaGondolas = new List<Gondola>();

        public void Embarcar(int numero, Crianca crianca1, Pessoa crianca2)
        {
            
            
            //bool crianca1EstaAcompanhadoResponsavel = false;
            //bool crianca1PodeAndarSozinho = crianca1.Idade >= 12;

            //bool crianca1EstaAcompanhadoResponsavel = crianca1.Responsavel != null;

            //bool crianca2PodeAndarSozinho = crianca2.Idade >= 12;

            //bool crianca2EstaAcompanhadoResponsavel = crianca2.Responsavel != null;


            Gondola GondolaPreenchida = new Gondola();
            GondolaPreenchida.Numero = numero;
            GondolaPreenchida.Assento1 = crianca1;
            GondolaPreenchida.Assento2 = crianca2;

            if(GondolaPreenchida.Assento1.Responsavel == GondolaPreenchida.Assento2)
            {
                Console.WriteLine("Sim");
            }
            else
            {
                Console.WriteLine("Não");
            }


            for (int i = 0; i < 18; i++)
            {
                ListaGondolas.Add(new Gondola(i + 1, new Crianca("[Vazio]", 0), new Pessoa("[Vazio]", 0)));
            }

            this.AtualizarLista(GondolaPreenchida);

        }

        private void AtualizarLista(Gondola gondola)
        {
            ListaGondolas[gondola.Numero].Assento1 = gondola.Assento1;
            ListaGondolas[gondola.Numero].Assento2 = gondola.Assento2;
        }

        public void status()
        {
            foreach (Gondola item in ListaGondolas)
            {
                Console.WriteLine(item.Numero + " " + item.Assento1.Nome + " " + item.Assento2.Nome);
            }
        }
    }
}
