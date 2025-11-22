using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batalha_Personagens
{
    public interface IPersonagem
    {
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int vida { get; set; }
        public void AcaoAtaque();
        public void AcaoDefesa();


    }
}
