using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    public class MinerSM : IMinerSM
    {
        public static int Id { get; set; }
        public void CalculateTask(Client client)
        {
            // TODO
            int solution = 0;
            Console.WriteLine("Calculating task!!!");
            Console.WriteLine("Client data : " + client.FormattedString);

            string address = "net.tcp://localhost:4000/ISmartContractMiner";
            NetTcpBinding binding = new NetTcpBinding();

            ChannelFactory<ISmartContractMiner> channel = new ChannelFactory<ISmartContractMiner>(binding, address);
            ISmartContractMiner proxy = channel.CreateChannel();
            List<Miner> miners = proxy.ReturnAllMiners(Id);
            channel.Close();

            foreach (var item in miners)
            {
                address = item.Address + "/IMinerSM";
                binding = new NetTcpBinding();

                ChannelFactory<IMinerSM> channelMiner = new ChannelFactory<IMinerSM>(binding, address);

                IMinerSM proxyMiner = channelMiner.CreateChannel();

                bool isValid = proxyMiner.ValidateTask(client, solution);
                if (!isValid)
                {
                    Console.WriteLine("Task solution is not valid");
                    break;
                }
            }
        }

        public bool ValidateTask(Client client, int value)
        {
            // TODO isvalid
            Console.WriteLine("Check validity :" + client.FormattedString);
            return true;
        }
    }
}
