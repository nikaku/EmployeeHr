﻿using EmployeeHr.BL.Dtos.Settlement;

namespace EmployeeHr.BL.Dtos.Address
{
    public class GetAddressDto
    {
        public int Id { get; set; }
        public string AddressDescription { get; set; }
        public GetSettlementDto settlement { get; set; }
    }
}
