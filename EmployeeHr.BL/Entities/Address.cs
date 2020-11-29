namespace Hr.BL.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public Settlement Settlement { get; set; }
        public int SettlementId { get; set; }
    }
}
