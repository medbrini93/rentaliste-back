using System;
using rentaliste_api.Repository.Interfaces;

namespace rentaliste_api.Repository.UnitOfWork.Interface
{
	public interface IUnitOfWork : IDisposable
	{
		ICommunicationRepository Communications { get; }
		ICommunicationTypeRepository CommunicationTypes { get; }
		IDocumentRepository Documents { get; }
		IDocumentTypeRepository DocumentTypes { get; }
		ILeaseRepository Leases { get; }
		IMaintenanceRequestRepository MaintenanceRequests { get; }
		IMaintenanceTypeRepository MaintenanceTypes { get; }
		IOwnerRepository Owners { get; }
		IPositionRepository Positions { get; }
		IPrivilegeRepository Privileges { get; }
		IPropertyRepository Properties { get; }
		IPropertyTypeRepository PropertyTypes { get; }
		IStaffRepository Staffs { get; }
		ITenantRepository Tenants { get; }
		ITransactionRepository Transactions { get; }
		ITransactionTypeRepository TransactionTypes { get; }
		IUserRepository Users { get; }
		int Complete();
    }
}

