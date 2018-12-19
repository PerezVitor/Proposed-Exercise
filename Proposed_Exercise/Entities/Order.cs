using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proposed_Exercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus order { get; set; }
    }
}
