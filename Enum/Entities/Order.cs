using CourseEnum.Entities.Enums;
using System; 

namespace Enum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } // usa o OrderStatus que é Enum para atribuir o Status do pedido

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
