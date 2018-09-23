using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host;
            try
            {
                host = new ServiceHost(typeof(MineSweeperServer.MineSweeperService));
                host.Description.Behaviors.Add(
                    new ServiceMetadataBehavior { HttpGetEnabled = true });
                host.Open();
                Console.WriteLine("Connected to service");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
