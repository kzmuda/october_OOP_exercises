namespace october_OOP_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderItem orderItem = new OrderItem("mleko", 3.2m ,4);
            Console.WriteLine(orderItem);
        }
    }
}