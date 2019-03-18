using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVc_2.Contracts
{
    interface IRepository
    {
        bool Login(string username, string password);
        void AddToCart(int UserID, int ItemID);
        void Delete(int id);
        void AddToInvoice(int AccountID);
    }
}
