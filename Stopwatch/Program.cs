using System;
using System.Threading;

namespace Stopwatch {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("H = Horas => 1h = 1 hora");
            Console.WriteLine("0 = sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string opcao = Console.ReadLine().ToLower();

            if (opcao == "0") {
                System.Environment.Exit(0);
            }

            char tipo = char.Parse(opcao.Substring(opcao.Length - 1, 1));
            int tempo = int.Parse(opcao.Substring(0, opcao.Length - 1));

            int multi = 1;

            if (tipo == 'm') {
                multi = 60;
            } else if (tipo == 'h') {
                multi = 3600;
            }

            Start(tempo * multi);
        }

        static void Start(int tempo) {
            int currentTime = 0;
            
            while(currentTime != tempo) {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
