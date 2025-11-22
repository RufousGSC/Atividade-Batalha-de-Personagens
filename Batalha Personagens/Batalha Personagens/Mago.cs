using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Personagens
{
    internal class Mago : IPersonagem
    {
        public int Ataque { get; set; } = 0;

        public int Defesa { get; set; } = 0;

        public int vida { get; set; } = 70;

        public void AcaoAtaque()
        {
            Random RndAtaque = new Random();
            this.Ataque = RndAtaque.Next(1, 31);
        }

        public void AcaoDefesa()
        {
            Random RndDefesa = new Random();
            this.Defesa = RndDefesa.Next(1, 11);
        }

        public int GetAtaque()
        {
            return this.Ataque;
        }

        public int GetDefesa()
        {
            return this.Defesa;
        }
    }
}
