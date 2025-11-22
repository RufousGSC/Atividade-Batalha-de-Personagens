

using Batalha_Personagens;
using System.Reflection.PortableExecutable;

IPersonagem Guerreiro = new Guerreiro();
IPersonagem Mago = new Mago();

Guerreiro.AcaoAtaque();
Guerreiro.AcaoDefesa();

Mago.AcaoAtaque();
Mago.AcaoDefesa();

Random random1 = new Random();
Random random2 = new Random();

while (true)
{
    int EscolhaGuerreiro = random1.Next(0,2);
    int EscolhaMago = random2.Next(0, 2);

    if (EscolhaGuerreiro == 0 && EscolhaMago == 1)
    {
        if (Guerreiro.GetAtaque() == Mago.GetDefesa())
        {
            Console.WriteLine("Empate " + Guerreiro.GetAtaque() + " x " + Mago.GetDefesa() + "\n");
        }
        else
        {
            if (Guerreiro.GetAtaque() < Mago.GetDefesa())
            {
                Console.WriteLine("\nGuerreiro perdeu Ataque contra Defesa " + Guerreiro.GetAtaque() + " x " + Mago.GetDefesa() + "\n");
                Guerreiro.vida = Guerreiro.vida + (Guerreiro.GetAtaque() - Mago.GetDefesa());
                Console.WriteLine("Dano causado pelo Mago: " + (Mago.GetDefesa() - Guerreiro.GetAtaque()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
            else
            {
                Console.WriteLine("\nMago Perdeu Defesa contra Ataque " + Guerreiro.GetAtaque() + " x " + Mago.GetDefesa() + "\n");
                Mago.vida = Mago.vida - (Guerreiro.GetAtaque() - Mago.GetDefesa());
                Console.WriteLine("Dano causado pelo Guerreiro: " + (Guerreiro.GetAtaque() - Mago.GetDefesa()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
        }
    }  

    if (EscolhaGuerreiro == 1 && EscolhaMago == 0)
    {
        if (Guerreiro.GetDefesa() == Mago.GetAtaque())
        {
            Console.WriteLine("Empate " + Guerreiro.GetAtaque() + " x " + Mago.GetDefesa() + "\n");
        }
        else
        {
            if (Guerreiro.GetDefesa() < Mago.GetAtaque())
            {
                Console.WriteLine("\nGuerreiro perdeu Defesa contra Ataque " + Guerreiro.GetDefesa() + " x " + Mago.GetAtaque() + "\n");
                Guerreiro.vida = Guerreiro.vida + (Guerreiro.GetDefesa() - Mago.GetAtaque());
                Console.WriteLine("Dano causado pelo Mago: " + (Mago.GetAtaque() - Guerreiro.GetDefesa()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
            else
            {
                Console.WriteLine("\nMago Perdeu Ataque contra Defesa " + Guerreiro.GetDefesa() + " x " + Mago.GetAtaque() + "\n");
                Mago.vida = Mago.vida - (Guerreiro.GetDefesa() - Mago.GetAtaque());
                Console.WriteLine("Dano causado pelo Guerreiro: " + ( Guerreiro.GetDefesa() - Mago.GetAtaque()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
        }
    }    

    if (EscolhaGuerreiro == 0 && EscolhaMago == 0)
    {
        if (Guerreiro.GetAtaque() == Mago.GetAtaque())
        {
            Console.WriteLine("Empate " + Guerreiro.GetAtaque() + " x " + Mago.GetAtaque() + "\n");
        }
        else
        {
            if (Guerreiro.GetAtaque() < Mago.GetAtaque())
            {
                Console.WriteLine("\nGuerreiro perdeu Ataque Contra Ataque " + Guerreiro.GetAtaque() + " x " + Mago.GetAtaque() + "\n");
                Guerreiro.vida = Guerreiro.vida + (Guerreiro.GetAtaque() - Mago.GetAtaque());
                Console.WriteLine("Dano causado pelo Mago: " + (Mago.GetAtaque() - Guerreiro.GetAtaque()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
            else
            {
                Console.WriteLine("\nMago Perdeu Ataqua contra Ataque " + Guerreiro.GetAtaque() + " x " + Mago.GetAtaque() + "\n");
                Mago.vida = Mago.vida - (Guerreiro.GetAtaque() - Mago.GetAtaque());
                Console.WriteLine("Dano causado pelo Guerreiro: " + (Guerreiro.GetAtaque() - Mago.GetAtaque()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
        }
    }

    if (EscolhaGuerreiro == 1 && EscolhaMago == 1)
    {
        if (Guerreiro.GetDefesa() == Mago.GetDefesa())
        {
            Console.WriteLine("Empate " + Guerreiro.GetDefesa() + " x " + Mago.GetDefesa() + "\n");
        }
        else
        {
            if (Guerreiro.GetDefesa() < Mago.GetDefesa())
            {
                Console.WriteLine("\nGuerreiro perdeu Defesa Contra Defesa " + Guerreiro.GetDefesa() + " x " + Mago.GetDefesa() + "\n");
                Guerreiro.vida = Guerreiro.vida + (Guerreiro.GetDefesa() - Mago.GetDefesa());
                Console.WriteLine("Dano causado pelo Mago: " + (Mago.GetDefesa() - Guerreiro.GetDefesa()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
            else
            {
                Console.WriteLine("\nMago Perdeu Defesa contra Defesa " + Guerreiro.GetDefesa() + " x " + Mago.GetDefesa() + "\n");
                Mago.vida = Mago.vida - (Guerreiro.GetDefesa() - Mago.GetDefesa());
                Console.WriteLine("Dano causado pelo Guerreiro: " + (Guerreiro.GetDefesa() - Mago.GetDefesa()));
                Console.WriteLine("\nGuerreiro vida: " + Guerreiro.GetVida() + "\nMago Vida: " + Mago.GetVida());
            }
        }
    }

    Console.WriteLine("------------------------");

    Guerreiro.AcaoAtaque();
    Guerreiro.AcaoDefesa();

    Mago.AcaoAtaque();
    Mago.AcaoDefesa();
    if(Guerreiro.GetVida() <= 0)
    {
        Console.WriteLine("PARABENS O MAGO GANHOU O DUELO");
    }
    
    if(Mago.GetVida() <= 0)
    {
        Console.WriteLine("PARABENS O GUERREIRO GANHOU O DUELO");
    }

    if (Guerreiro.GetVida() <= 0 || Mago.GetVida() <= 0)
    {
        break;
    }
    Thread.Sleep(400);
}





