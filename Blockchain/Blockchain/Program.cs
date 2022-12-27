using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Blockchain blockchain1 = new Blockchain();
            List<Miner> Miners = new List<Miner>();
            Miners.Add(new Miner("1", 0.5323, false));
            Miners.Add(new Miner ("10",3.1123,true));
            Miners.Add(new Miner ("11",3.5422,false));
            Miners.Add(new Miner ("5",1.3244, true));
            Miners.Add(new Miner ("3",0.0032,false));
            Miners.Add(new Miner ("2",0.9882,true));
            Miners.Add(new Miner ("4",0.5342,true));
            Miners.Add(new Miner ("6",0.2223,true));
            Miners.Add(new Miner ("7",0.4232,false));
            Miners.Add(new Miner ("8",2.3232,true));
            Miners.Add(new Miner ("9",2.9984,false));


        }
    }
}
