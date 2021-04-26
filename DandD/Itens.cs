using System;
using System.Collections.Generic;
using System.Text;
using DandD.Herois;

namespace DandD
{
    public class Itens
    {
        public bool Espada { get; set; }
        public bool Cajado { get; set; }
        public bool Arco { get; set; }


        public Itens()
        {
            Espada = false;
            Cajado = false;
            Arco = false;
        }

        public Itens(Guerreiro guerreiro)
        {
            Espada = true;          
        }

        public Itens(Arqueiro guerreiro)
        {
            Arco = true;
        }

        public Itens(Mago guerreiro)
        {
            Cajado = true;
        }

    }
}
