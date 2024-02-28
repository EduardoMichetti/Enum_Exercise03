using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03.Entities.Enums
{
    enum OrderStatus: int
    {
        Pending_Payment,
        Processing,
        Shipped,
        Delivered
    }
}
