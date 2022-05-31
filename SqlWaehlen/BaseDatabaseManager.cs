using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    public abstract class BaseDatabaseManager
    {
        public abstract void GetData();
        public abstract void CreatFunksion();
        public abstract void ReadFunksion();
        public abstract void UpdateFunksion();

        public abstract void DeleteFunksion();
    }

}
