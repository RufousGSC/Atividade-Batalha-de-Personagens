

using Batalha_Personagens;
using System.Reflection.PortableExecutable;

IPersonagem Jogador1 = new Guerreiro();
IPersonagem Jogador2 = new Mago();

Jogador1.AcaoAtaque();
Jogador1.AcaoDefesa();

Jogador2.AcaoAtaque();
Jogador2.AcaoDefesa();

while (true)
{
    if (Jogador1.GetAtaque() < Jogador2.GetDefesa())
    {
        Console.WriteLine("\nJogador 1 perdeu " + Jogador1.GetAtaque() + " + " + Jogador2.GetDefesa() + "\n");
        Jogador1.vida = Jogador1.vida + (Jogador1.GetAtaque() - Jogador2.GetDefesa());
        Console.WriteLine("jogador 2 vida: " + Jogador2.GetVida() + "\nJogador 1 Vida: " + Jogador1.GetVida());
    }
    else
    {
        Console.WriteLine("\nJogador 2 Perdeu " + Jogador1.GetAtaque() + " + " + Jogador2.GetDefesa() + "\n");
        Jogador2.vida = Jogador2.vida - (Jogador1.GetAtaque() - Jogador2.GetDefesa());
        Console.WriteLine("Jogador 1 vida: " + Jogador1.GetVida() + "\nJogador 2 Vida: " + Jogador2.GetVida());
    }

    Jogador1.AcaoAtaque();
    Jogador1.AcaoDefesa();

    Jogador2.AcaoAtaque();
    Jogador2.AcaoDefesa();

    if (Jogador1.GetVida() <= 0 || Jogador2.GetVida() <= 0)
    {
        break;
    }
}





