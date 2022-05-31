using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    public class MySqlDBManager :BaseDatabaseManager
    {
        public override void CreatFunksion()
        {
            Console.WriteLine("MySql Database Data Created...");
        }

        public override void DeleteFunksion()
        {
            Console.WriteLine("MySql Database Data Deleted...");
        }

        public override void GetData()
        {
            Console.WriteLine("MySql Database benutzt...");

        }

        public override void ReadFunksion()
        {
            Console.WriteLine("MySql Database Data Readed...");
        }

        public override void UpdateFunksion()
        {
            Console.WriteLine("MySql Database Data Updated...");
        }
    }
}
