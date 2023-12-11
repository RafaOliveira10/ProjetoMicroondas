using System;
using System.Threading;

public class Program
{
    static void Main()
    {
        Microondas microondas = new Microondas();
        microondas.IniciarInterface();
    }
}

public class Microondas
{
    private int potencia;
    private int tempo;
    private string stringAquecimento;

    public void IniciarInterface()
    {
        Console.WriteLine("\r\n███╗░░░███╗██╗░█████╗░██████╗░░█████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗  ██████╗░░█████╗░███████╗███████╗\r\n████╗░████║██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝  ╚════██╗██╔══██╗╚════██║╚════██║\r\n██╔████╔██║██║██║░░╚═╝██████╔╝██║░░██║██║░░██║██╔██╗██║██║░░██║███████║╚█████╗░  ░░███╔═╝██║░░██║░░░░██╔╝░░░░██╔╝\r\n██║╚██╔╝██║██║██║░░██╗██╔══██╗██║░░██║██║░░██║██║╚████║██║░░██║██╔══██║░╚═══██╗  ██╔══╝░░██║░░██║░░░██╔╝░░░░██╔╝░\r\n██║░╚═╝░██║██║╚█████╔╝██║░░██║╚█████╔╝╚█████╔╝██║░╚███║██████╔╝██║░░██║██████╔╝  ███████╗╚█████╔╝░░██╔╝░░░░██╔╝░░\r\n╚═╝░░░░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚══════╝░╚════╝░░░╚═╝░░░░░╚═╝░░░");
        Console.WriteLine("\n1. Informar tempo e potência");
        Console.WriteLine("2. Início rápido");
        Console.Write("Escolha uma opção: ");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                InformarTempoEPotencia();
                break;
            case 2:
                InicioRapido();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }

    private void InformarTempoEPotencia()
    {
        Console.Write("Informe o tempo em segundos: ");
        tempo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe a potência (1 a 10, padrão 10): ");
        potencia = Convert.ToInt32(Console.ReadLine());

        if (potencia < 1 || potencia > 10)
        {
            Console.WriteLine("Potência inválida. Usando potência padrão 10.");
            potencia = 10;
        }

        ValidarTempo();

        IniciarAquecimento();
    }

    private void InicioRapido()
    {
        tempo = 30;
        potencia = 10;

        IniciarAquecimento();
    }

    private void ValidarTempo()
    {
        if (tempo < 1 || tempo > 120)
        {
            Console.WriteLine("Tempo inválido. Informe um tempo entre 1 segundo e 2 minutos.");
            IniciarInterface();
        }

        if (tempo > 60 && tempo < 100)
        {
            Console.WriteLine("Convertendo o tempo para minutos.");
            tempo = tempo / 60;
        }
    }

    private void IniciarAquecimento()
    {
        Console.WriteLine($"Iniciando aquecimento com tempo {tempo} segundos e potência {potencia}.");
        stringAquecimento = new string('.', tempo * potencia / 10);

        for (int i = 0; i < tempo; i++)
        {
            Console.Write(stringAquecimento);
            Thread.Sleep(1000);
        }

        Console.WriteLine("\n\nAquecimento finalizado!");
        Console.WriteLine("\nVolte sempre!");
    }
}