using Dell.Contracts;
using System;

namespace Dell.Business.Base
{
    public class BaseShippingCost<TEntity>
        : IShippingCosts<TEntity>
        where TEntity : class
    {
        public virtual void CalculateCost(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
