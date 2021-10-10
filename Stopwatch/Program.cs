using System;
using System.Threading;

namespace Stopwatch {
    class Program {
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("H = Horas");
            Console.WriteLine("0 = sair");
            Console.Write("Quanto tempo deseja contar? ");
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
