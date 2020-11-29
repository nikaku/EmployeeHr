using Hr.BL.Dtos.Settlement;

namespace Hr.BL.Dtos.Address
{
    public class GetAddressDto
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public GetSettlementDto settlement { get; set; }
    }
}
