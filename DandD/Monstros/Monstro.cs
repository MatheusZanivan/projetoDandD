using System;
using System.Collections.Generic;
using System.Text;
using DandD.Herois;

namespace DandD.Monstros
{
    public class Monstro
    {
        public int Level { get; set; }
        public Status Status { get; set; }

        public Monstro(int level, int forca, int defesa, int agilidade, int sorte, int vida, int mana)
        {
            Level = level;
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
        }

        public void atacar(Heroi heroi)
        {
            Random rand = new Random();
            float sorte = rand.Next(0, this.Status.Sorte);
            int ataque = (int)((this.Status.Forca + this.Status.Agilidade) * (1 + (sorte / 100)));
            heroi.recebeAtaque(ataque);
        }

        public int defesa()
        {
            Random rand = new Random();
            float sorte = rand.Next(0, this.Status.Sorte);
            return (int)((this.Status.Defesa + this.Status.Agilidade) * (1 + (sorte / 100)));
        }

        public void recebeAtaque(int dano)
        {
            int defesa = this.defesa();
            dano = defesa - dano;
            if (dano < 0)
            {
                this.Status.Vida += dano;
                return;
            }
        }
    }
}
