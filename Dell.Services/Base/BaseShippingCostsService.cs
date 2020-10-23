using Dell.Contracts;
using System;

namespace Dell.Services.Base
{
    public class BaseShippingCostsService<TEntity>
        : IShippingCostsService<TEntity>
        where TEntity : class
    {
        public virtual void ShippingOrder(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
