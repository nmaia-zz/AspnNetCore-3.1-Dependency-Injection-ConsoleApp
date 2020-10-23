using Dell.Business.Base;
using Dell.Contracts;

namespace Dell.Business
{
    public class ShippingOrderCost
		: BaseShippingCost<Order>
		, IShippingCostsOrder
	{
		public override void CalculateCost(Order order)
		{
			switch (order.ShoppingType)
			{
				case "FEDEX":
					order.Value += 10m;
					break;
				case "PRIVATE_SENDER":
					order.Value += 20m;
					break;
				case "UPS":
					order.Value += 20m;
					break;
				default:
					order.Value += 5m;
					break;
			}
		}
	}
}
