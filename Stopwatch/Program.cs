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

        }

        static void Start(int time) {
            int currentTime = 0;
            
            while(currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
        }
    }
}
