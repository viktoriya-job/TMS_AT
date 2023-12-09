
namespace OOP.TransportHierarchy
{
    internal class TransportPersonalBike : TransportPersonal
    {
        public TransportPersonalBike() : base() => TransportPersonalKind = "Велосипед";
        public TransportPersonalBike(DateOnly purchaseDate, string color) : this()
        {
            PurchaseDate = purchaseDate;
            Color = color;
        }
    }
}
