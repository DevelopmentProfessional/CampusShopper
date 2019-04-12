using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVc_2.Models;
using MVc_2.Data;

namespace MVc_2.Contracts
{
    interface FactoryRepository
    {
        SnacksDB CreateSnacks();
        DataAccess CreateDataAccess();
    }
}
