using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDB
{
    class Program
    {
        static void Main(string[] args)
        {
           
            using (var context = new MSContext("MinesweeperDataBase"))
            {
                context.Database.Initialize( true);
            }
        }
    }
}
