namespace Dell.Contracts
{
    public interface IShippingCosts<TEntity>
        where TEntity : class
    {
        void CalculateCost(TEntity obj);
    }
}
