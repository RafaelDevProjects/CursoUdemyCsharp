namespace EnumTopic.Entities.Enums
{
    enum OrderStatus : int // O order Status é derivado do tipo int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
