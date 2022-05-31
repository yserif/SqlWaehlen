using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWaehlen
{
    public class CustomerManager
    {
        public BaseDatabaseManager baseDataManager;
        public void GetCustomer()
        {
            baseDataManager.GetData();
        }
        public void CreatFn()
        {
            baseDataManager.CreatFunksion();
        }
        public void ReadFn()
        {
            baseDataManager.ReadFunksion();
        }
        public void UpdateFn()
        {
            baseDataManager.UpdateFunksion();
        }
        public void DeleteFn()
        {
            baseDataManager.DeleteFunksion();
        }

    }
}
