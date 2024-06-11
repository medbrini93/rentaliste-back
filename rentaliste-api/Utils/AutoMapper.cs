using AutoMapper;
using rentaliste_api.Models.db;
using rentaliste_api.Models.dto;

namespace rentaliste_api.Utils
{
	public class AutoMapper : Profile
	{
		public AutoMapper()
		{
			CreateMap<Communication, MaintenanceRequestDto>();
            CreateMap<CommunicationType, MaintenanceTypeDto>();           
            CreateMap<Document, MaintenanceRequestDto>();
            CreateMap<Lease, MaintenanceRequestDto>();
            CreateMap<MaintenanceRequest, MaintenanceRequestDto>();
            CreateMap<MaintenanceType, MaintenanceTypeDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Position, PositionDto>();
            CreateMap<Privilege, PrivilegeDto>();
            CreateMap<Property, PropertyDto>();
            CreateMap<PropertyType, PropertyTypeDto>();
            CreateMap<Staff, StaffDto>();
            CreateMap<Tenant, TenantDto>();
            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionType, TransactionTypeDto>();
            CreateMap<User, UserDto>();

            //Reverse mapping
            CreateMap<MaintenanceRequestDto, Communication>();
            CreateMap<MaintenanceTypeDto, CommunicationType>();
            CreateMap<MaintenanceRequestDto, Document>();
            CreateMap<MaintenanceRequestDto, Lease>();
            CreateMap<MaintenanceRequestDto, MaintenanceRequest>();
            CreateMap<MaintenanceTypeDto, MaintenanceType>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<PositionDto, Position>();
            CreateMap<PrivilegeDto, Privilege>();
            CreateMap<PropertyDto, Property>();
            CreateMap<PropertyTypeDto, PropertyType>();
            CreateMap<StaffDto, Staff>();
            CreateMap<TenantDto, Tenant>();
            CreateMap<TransactionDto, Transaction>();
            CreateMap<TransactionTypeDto, TransactionType>();
            CreateMap<UserDto, User>();
        }
	}
}

