using System;
using System.Threading;

namespace Stopwatch {
    class Program {
        static void Main(string[] args) {
            Start();
        }

        static void Start() {
            int time = 10;
            int currentTime = 0;
            
            while(currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}
