using MVc_2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVc_2.Models;
using MVc_2.Data;

namespace MVc_2.Controllers
{
    public class FactorySettings : FactoryRepository
    {
        public SnacksDB CreateSnacks()
        {
            return new SnacksDB();
        }

        public DataAccess CreateDataAccess()
        {
            return new DataAccess();
        }
    }
}

