using System;
using System.Collections.Generic;
using System.Text;

namespace DandD.Monstros
{
    class Goblin : Monstro
    {
        public Goblin(int level, int forca, int defesa, int agilidade, int sorte, int vida, int mana) : base(level, forca, defesa, agilidade, sorte, vida, mana)
        {
            Level = level;
            this.Status = new Status(forca, defesa, agilidade, sorte, vida, mana);
        }
    }
}
