using System;
using System.Collections.Generic;
using System.Text;
using DandD.Monstros;

namespace DandD.Herois
{
    public class Arqueiro : Heroi
    {
        public Arqueiro(string nome, int idade, int level, int forca, int defesa, int agilidade, int sorte, int vida, int mana, string classe) : base(nome, idade, level, forca, defesa, agilidade, sorte, vida, mana, classe)
        {
            this.Nome = nome;
            this.Idade = Idade;
            this.Level = level;
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
        }

        public override void atacar(Monstro monstro)
        {
            Random rand = new Random();
            float sorte = rand.Next(0, this.Status.Sorte);
            if (this.Itens.Arco == true)
            {
                this.Status.Forca += 3;
                this.Status.Agilidade += 5;
            }
            int ataque = (int)((this.Status.Forca + this.Status.Agilidade) * (1 + (sorte / 100)));
            monstro.recebeAtaque(ataque);
        }
    }
}
