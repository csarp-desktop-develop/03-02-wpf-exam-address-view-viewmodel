namespace Kreta.Shared.Models
{
    public class Address : IDbEntity<Address>
    {
        public Guid Id { get; set; }
        public int ZipCode { get; set; }
        public string Street { get; set; } = string.Empty;
        public int HouseNumber { get; set; }

        public bool IsValidZipCode => ZipCode >0;
        public bool IsStreetValid => ! string.IsNullOrEmpty(Street);

        // Konstruktorok
        // ToString
        public override string ToString()
        {
            return $"{ZipCode} {Street} {HouseNumber}";
        }
    }
}
