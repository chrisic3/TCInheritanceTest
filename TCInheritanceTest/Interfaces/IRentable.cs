namespace TCInheritanceTest
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    }
}
