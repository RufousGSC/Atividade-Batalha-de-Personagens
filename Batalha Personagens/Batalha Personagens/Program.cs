

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
    if (Jogador1.GetAtaque() == Jogador2.GetDefesa())
    {
        Console.WriteLine("Empate " + Jogador1.GetAtaque() + " + " + Jogador2.GetDefesa() + "\n");
    }
    else
    {
        if (Jogador1.GetAtaque() < Jogador2.GetDefesa())
        {
            Console.WriteLine("\nJogador 1 perdeu Ataque " + Jogador1.GetAtaque() + " x " + Jogador2.GetDefesa() + "\n");
            Jogador1.vida = Jogador1.vida + (Jogador1.GetAtaque() - Jogador2.GetDefesa());
            Console.WriteLine("jogador 1 vida: " + Jogador1.GetVida() + "\nJogador 2 Vida: " + Jogador2.GetVida());
        }
        else
        {
            Console.WriteLine("\nJogador 2 Perdeu Defesa " + Jogador1.GetAtaque() + " x " + Jogador2.GetDefesa() + "\n");
            Jogador2.vida = Jogador2.vida - (Jogador1.GetAtaque() - Jogador2.GetDefesa());
            Console.WriteLine("Jogador 1 vida: " + Jogador1.GetVida() + "\nJogador 2 Vida: " + Jogador2.GetVida());
        }
    }

    Console.WriteLine("-------------------------------");
    if (Jogador1.GetDefesa() == Jogador2.GetAtaque())
    {
        Console.WriteLine("Empate " + Jogador1.GetAtaque() + " x " + Jogador2.GetDefesa() + "\n");
    }
     else 
     {
        if (Jogador1.GetDefesa() < Jogador2.GetAtaque())
        {
            Console.WriteLine("\nJogador 1 perdeu Defesa " + Jogador1.GetDefesa() + " x " + Jogador2.GetAtaque() + "\n");
            Jogador1.vida = Jogador1.vida + (Jogador1.GetDefesa() - Jogador2.GetAtaque());
            Console.WriteLine("jogador 1 vida: " + Jogador1.GetVida() + "\nJogador 2 Vida: " + Jogador2.GetVida());
        }
        else
        {
            Console.WriteLine("\nJogador 2 Perdeu Ataque " + Jogador1.GetDefesa() + "  " + Jogador2.GetAtaque() + "\n");
            Jogador2.vida = Jogador2.vida - (Jogador1.GetDefesa() - Jogador2.GetAtaque());
            Console.WriteLine("jogador 1 vida: " + Jogador1.GetVida() + "\nJogador 2 Vida: " + Jogador2.GetVida());
        }
     }

    Console.WriteLine("xxxxx---------xxxxx----------xxxx");

    Jogador1.AcaoAtaque();
    Jogador1.AcaoDefesa();

    Jogador2.AcaoAtaque();
    Jogador2.AcaoDefesa();

    if (Jogador1.GetVida() <= 0 || Jogador2.GetVida() <= 0)
    {
        break;
    }
}





