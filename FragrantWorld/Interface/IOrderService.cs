using FragrantWorld.modeles;


namespace FragrantWorld.Interface
{
    public interface IOrderService
    {
        Order GetOrderById(int orderId);
        void UpdateOrder(Order order);
        List<Order> GetAllOrders();
    }
}
