using System;
using System.Collections.Generic;
using System.Text;
using DandD.Monstros;

namespace DandD.Herois
{
    abstract public class Heroi
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Level { get; set; }
        public Status Status { get; set; }
        public Itens Itens { get; set; }

        public string Classe { get; set; }

        public Heroi(string nome, int idade, int level, int forca, int defesa, int agilidade, int sorte, int vida, int mana,string classe)
        {
            this.Nome = nome;
            this.Idade = Idade;
            this.Level = level;
            this.Classe = classe;
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
            this.Itens = new Itens();
        }

        public abstract void atacar(Monstro monstro);
       

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

            if(dano < 0)
            {
                this.Status.Vida += dano;
                return;
            }
        }

    }
}
