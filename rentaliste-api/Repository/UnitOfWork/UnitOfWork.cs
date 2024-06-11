using System;
using rentaliste_api.Models;
using rentaliste_api.Repository.Interfaces;
using rentaliste_api.Repository.UnitOfWork.Interface;

namespace rentaliste_api.Repository.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
        private readonly ApplicationContext _context;

        public ICommunicationRepository Communications { get; private set; }
        public ICommunicationTypeRepository CommunicationTypes { get; private set; }
        public IDocumentRepository Documents { get; private set; }
        public IDocumentTypeRepository DocumentTypes { get; private set; }
        public ILeaseRepository Leases { get; private set; }
        public IMaintenanceRequestRepository MaintenanceRequests { get; private set; }
        public IMaintenanceTypeRepository MaintenanceTypes { get; private set; }
        public IOwnerRepository Owners { get; private set; }
        public IPositionRepository Positions { get; private set; }
        public IPrivilegeRepository Privileges { get; private set; }
        public IPropertyRepository Properties { get; private set; }
        public IPropertyTypeRepository PropertyTypes { get; private set; }
        public IStaffRepository Staffs { get; private set; }
        public ITenantRepository Tenants { get; private set; }
        public ITransactionRepository Transactions { get; private set; }
        public ITransactionTypeRepository TransactionTypes { get; private set; }
        public IUserRepository Users { get; private set; }

        public UnitOfWork(ApplicationContext context)
		{
			_context = context;
            Communications = new CommunicationRepository(_context);
            CommunicationTypes = new CommunicationTypeRepository(_context);
            Documents = new DocumentRepository(_context);
            DocumentTypes = new DocumentTypeRepository(_context);
            Leases = new LeaseRepository(_context);
            MaintenanceRequests = new MaintenanceRequestRepository(_context);
            MaintenanceTypes = new MaintenanceTypeRepository(_context);
            Owners = new OwnerRepository(_context);
            Positions = new PositionRepository(_context);
            Privileges = new PrivilegeRepository(_context);
            Properties = new PropertyRepository(_context);
            PropertyTypes = new PropertyTypeRepository(_context);
            Staffs = new StaffRepository(_context);
            Tenants = new TenantRepository(_context);
            Transactions = new TransactionRepository(_context);
            TransactionTypes = new TransactionTypeRepository(_context);
            Users = new UserRepository(_context);
		}

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

