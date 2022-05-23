using System;

namespace ConsoleRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Goblin = 30;
            int voce = 60;
            int acao = 0;
            int mana = 10;
            Random num = new Random();
            int danovc = 0;
            int danoGb = 0;
            int defesavc = 0;
            int curavc = 0;
            bool vitoria = false;
            Console.WriteLine("Combate Iniciado!");
            Console.ReadLine();
            while (Goblin > 0 && Goblin != 0)
            {
                Console.WriteLine();
                Console.WriteLine("HP: "+ Goblin);
                Console.WriteLine("Goblin");
                Console.WriteLine(" ('T_T)");
                Console.WriteLine(@" /|  |\");
                Console.WriteLine("  o  o");

                Console.WriteLine("------------");
                Console.WriteLine();
                Console.WriteLine("Seu HP: " + voce);
                Console.WriteLine("Sua mana: " + mana);
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - defesa");
                Console.WriteLine("3 - cura");
                Console.WriteLine("O que vc deseja fazer?");
                Console.Write("digite o codigo: ");
                acao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (acao == 1)
                {
                    danovc = num.Next(5, 13);
                    danoGb = num.Next(9, 16);

                    Goblin = Goblin - danovc;
                    voce = voce - danoGb;
                }
                else if (acao == 2)
                {
                    danoGb = num.Next(9, 16);
                    defesavc = num.Next(3, 6);
                    voce = voce - (danoGb - defesavc);
                }
                else if (acao == 3)
                {
                    if (mana >= 5)
                    {
                        danoGb = num.Next(9, 16);
                        curavc = num.Next(13, 20);
                        voce = voce + curavc;
                        voce = voce - danoGb;
                        mana = mana - 5;
                    }
                    else
                    {
                        Console.WriteLine("Goblin");
                        Console.WriteLine(" ('T_T)");
                        Console.WriteLine(@"/|  |\");
                        Console.WriteLine("  o  o");
                        Console.WriteLine();
                        Console.WriteLine("Você nao tem mana sufuciente para essa ação!");
                        Console.ReadLine();
                        Console.Clear();
                        danoGb = num.Next(9, 16);
                        voce = voce - danoGb;
                    }
                }
                else
                {
                    Console.WriteLine("comando invalido!");
                    Console.WriteLine();
                    voce = voce - danoGb;
                }

                if (Goblin <= 0)
                {
                    Goblin = 0;
                    Console.WriteLine("Goblin");
                    Console.WriteLine("HP: " + Goblin);
                    Console.WriteLine("('x_x)");
                    Console.WriteLine(@"/|  |\");
                    Console.WriteLine(" o  o");
                    Console.WriteLine();
                    Console.WriteLine("Goblin Derrotado!");
                    vitoria = true;
                }

                if (Goblin > 0 && Goblin != 0)
                {
                    Console.WriteLine("Goblin");
                    Console.WriteLine("('T_T)");
                    Console.WriteLine(@"/|  |\");
                    Console.WriteLine(" o  o");
                    Console.WriteLine("você curou: " + curavc);
                    Console.WriteLine("você causou: " + danovc + " de dano");
                    Console.WriteLine("Goblin causou: " + danoGb + " de dano em voce");
                    Console.WriteLine("Voce defendeu: " + defesavc);
                    Console.WriteLine("Sua mana:" + mana);
                    Console.WriteLine();
                    Console.WriteLine("-----------");
                    Console.WriteLine("Seu HP: " + voce);
                    Console.WriteLine("Goblin HP: " + Goblin);
                    Console.ReadLine();
                    Console.Clear();
                    danovc = 0;
                    danoGb = 0;
                    curavc = 0;
                    defesavc = 0;
                }
                if (voce <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Voce morreu!");
                    Goblin = 0;
                    vitoria = false;
                }
            }
            if (vitoria == true)
            {
                Console.WriteLine();
                Console.WriteLine("Parabéns");
            }
            else Console.WriteLine("você foi derrotado!");
        }
    }
}
