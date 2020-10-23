namespace Dell.Contracts
{
    public interface IShippingCostsService<TEntity>
        where TEntity : class
    {
        void ShippingOrder(TEntity obj);
    }
}
