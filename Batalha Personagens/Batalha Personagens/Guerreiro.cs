using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Personagens
{
    internal class Guerreiro : IPersonagem
    {
        public int Ataque { get; set; } = 0;

        public int Defesa { get; set; } = 0;

        public int vida { get; set; } = 100;

        public void AcaoAtaque()
        {
            Random RndAtaque = new Random();
            this.Ataque = RndAtaque.Next(1,21);
        }

        public void AcaoDefesa()
        {
            Random RndDefesa = new Random();
            this.Defesa = RndDefesa.Next(1,31);
        }

        public int GetAtaque()
        {
            return this.Ataque;
        }

        public int GetDefesa()
        {
            return this.Defesa;
        }

        public int GetVida()
        {
            return this.vida;
        }

    }
}
