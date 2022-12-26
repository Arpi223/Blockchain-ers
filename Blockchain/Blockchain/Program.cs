using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Blockchain blockchain1 = new Blockchain();
            List<Miner> Miners = new List<Miner>();

            Miners.Add(new Miner { Id = "1", CurrentState = "0.5323BTC", started = false }) ;
            Miners.Add(new Miner { Id = "10", CurrentState = "3.1123BTC", started = true });
            Miners.Add(new Miner { Id = "11", CurrentState = "3.5422BTC", started = false });
            Miners.Add(new Miner { Id = "5", CurrentState = "1.3244BTC", started = true });
            Miners.Add(new Miner { Id = "3", CurrentState = "0.0032BTC", started = false });
            Miners.Add(new Miner { Id = "2", CurrentState = "0.9882BTC", started = true });
            Miners.Add(new Miner { Id = "4", CurrentState = "0.5342BTC", started = true });
            Miners.Add(new Miner { Id = "6", CurrentState = "0.2223BTC", started = true });
            Miners.Add(new Miner { Id = "7", CurrentState = "0.4232BTC", started = false });
            Miners.Add(new Miner { Id = "8", CurrentState = "2.3232BTC", started = true });
            Miners.Add(new Miner { Id = "9", CurrentState = "2.9984BTC", started = false });


        }
    }
}
