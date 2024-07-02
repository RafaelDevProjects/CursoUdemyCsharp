using EnumTopic.Entities;
using EnumTopic.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Permissions;
using System.Text;

namespace TopicEnum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } // usa o OrderStatus que é Enum para atribuir o Status do pedido
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }
        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach (var item in OrderItens)
            {
                total += item.SubTotal();
            }
            return total;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
