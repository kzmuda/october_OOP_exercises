namespace october_OOP_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderItem orderItem = new OrderItem("mleko", 3.2m ,4);
           // Console.WriteLine(orderItem);
            Order order = new Order();
            order.AddItem(orderItem);
            order.AddItem(new OrderItem("woda", 2.5m, 5));
            //string totalOrder = order.ToString();
            Console.WriteLine(order);

            if(order.GetValue() > 100)
            {
                Console.WriteLine("Jesteś klientem VIP");
            }
        }
    }
}