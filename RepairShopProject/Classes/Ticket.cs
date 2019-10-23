using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShopProject.Classes
{
    class Ticket
    {
        int id;
        int customerId;
        string startDate;
        string endEstimate;
        string info;
        Product product = new Product();
        string status;

    }
}
