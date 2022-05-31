using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    public class OracleDBManager : BaseDatabaseManager
    {

        public override void CreatFunksion()
        {
            Console.WriteLine("Oracle Database Data Created...");
        }

        public override void DeleteFunksion()
        {
            Console.WriteLine("Oracle Database Data Deleted...");
        }

        public override void GetData()
        {
            Console.WriteLine("Oracle Database benutzt...");

        }

        public override void ReadFunksion()
        {
            Console.WriteLine("Oracle Database Data Readed...");
        }

        public override void UpdateFunksion()
        {
            Console.WriteLine("Oracle Database Data Updated...");
        }

    }
}
