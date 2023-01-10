using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "net.tcp://localhost:4000/ISmartContractClient";
            NetTcpBinding binding = new NetTcpBinding();

            ChannelFactory<ISmartContractClient> channel = new ChannelFactory<ISmartContractClient>(binding, address);

            ISmartContractClient proxy = channel.CreateChannel();

            int counter = 0;
            Random rand = new Random();
            Common.Client client = new Common.Client(counter, rand.Next(1000));

            proxy.Calculate(client);

            counter++;
            Thread.Sleep(10000);



            Console.ReadKey();
        }
    }
}
