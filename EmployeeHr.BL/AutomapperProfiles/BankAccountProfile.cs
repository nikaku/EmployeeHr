using AutoMapper;
using Hr.BL.Dtos.BankAccount;
using Hr.BL.Entities;

namespace Hr.BL.AutomapperProfiles
{
    public class BankAccountProfile : Profile
    {
        public BankAccountProfile()
        {
            CreateMap<CreateBankAccountDto, BankAccount>();
            CreateMap<UpdateBankAccountDto, BankAccount>();
            CreateMap<BankAccount, GetBankAccountDto>();
        }
    }
}
