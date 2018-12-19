using Proposed_Exercise.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposed_Exercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order Items");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(Items.ToString());
            }
            sb.Append("Total price: " + Total().ToString("c"));

            return sb.ToString();
        }
    }
}
