using Dell.Contracts;
using Dell.Services.Base;
using System;

namespace Dell.Services
{
    public class ShippingCostsOrderService
        : BaseShippingCostsService<Order>
        , IShippingCostsOrderService
    {
        private readonly IShippingCostsOrder _shippingCostOrder;

        public ShippingCostsOrderService(IShippingCostsOrder shippingCostOrder)
        {
            _shippingCostOrder = shippingCostOrder;
        }

        public override void ShippingOrder(Order obj)
        {
            _shippingCostOrder.CalculateCost(obj);

            Console.WriteLine($"Order shipping will cost: {obj.Value}");
        }
    }
}
