using System;
using System.Collections.Generic;
using System.Text;

namespace DandD
{
    public class Status
    {
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Agilidade { get; set; }
        public int Sorte { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }

        public Status(int forca, int defesa, int agilidade, int sorte, int vida, int mana)
        {
            this.Forca = forca;
            this.Defesa = defesa;
            this.Agilidade = agilidade;
            this.Sorte = sorte;
            this.Vida = vida;
            this.Mana = mana;
        }
    }
}
