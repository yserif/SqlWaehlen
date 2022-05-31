using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    public class SqlServerDBManager : BaseDatabaseManager
    {
        public override void CreatFunksion()
        {
            Console.WriteLine("SqlServer Database Data Created...");
        }

        public override void DeleteFunksion()
        {
            Console.WriteLine("SqlServer Database Data Deleted...");
        }

        public override void GetData()
        {
            Console.WriteLine("SqlServer Database benutzt...");

        }

        public override void ReadFunksion()
        {
            Console.WriteLine("SqlServer Database Data Readed...");
        }

        public override void UpdateFunksion()
        {
            Console.WriteLine("SqlServer Database Data Updated...");
        }

    }
}