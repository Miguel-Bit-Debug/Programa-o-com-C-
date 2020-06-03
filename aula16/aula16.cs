
using System;

class Aula16
{

    static void Main()
    {

        int tempo = 0;
        char escolha;

    inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o Transporte: \n[a]Avião\n[c]Carro\n[o]Ônibus");

        escolha = char.Parse(Console.ReadLine());


        switch (escolha)
        {
            case 'a':
                tempo = 50;
                break;

            case 'c':
                tempo = 480;
                break;

            case 'o':
                tempo = 660;
                break;

            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("Transporte indisponivel");
        }
        else
        {
            Console.WriteLine("O tempo estimado de viagem é {0} minutos", tempo);
        }

        while (true)
        {
            try
            {
                Console.Write("\nCalcular outro transporte? [S/N]: ");
                escolha = char.Parse(Console.ReadLine());

                if (escolha == 's' || escolha == 'S')
                {
                    goto inicio;
                }
                else if (escolha == 'n' || escolha == 'N')
                {
                    Console.Clear();
                    Console.WriteLine("Fim do programa");
                    break;
                }
            }
            catch
            {
                Console.WriteLine("Erro! Digite apenas sim ou nao!");
            }
        }
    }

}