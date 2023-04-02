using System;
namespace october_OOP_exercises
{
	public class OrderItemWithContainer : OrderItem
	{
		private readonly string _containerName;
		private readonly decimal _containerPrice;

		public OrderItemWithContainer(string productName, decimal price, int quantity, string containerName, decimal containerPrice)
			: base(productName, price, quantity)
		{
			_containerName = containerName;
			_containerPrice = containerPrice;
		}

		public override string ToString()
		{
			return base.ToString() + $"; container: {_containerName}, container price: {_containerPrice}";
		}

		public override decimal GetValue()
		{
			return base.GetValue() + _containerPrice*quantity;
		}
	}
}