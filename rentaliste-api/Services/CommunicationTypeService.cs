using System;
using System.Linq.Expressions;
using AutoMapper;
using rentaliste_api.Models.db;
using rentaliste_api.Models.dto;
using rentaliste_api.Repository.UnitOfWork.Interface;
using rentaliste_api.Services.Interfaces;

namespace rentaliste_api.Services
{
	public class CommunicationTypeService : ICommunicationTypeService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CommunicationTypeService(IUnitOfWork unitOfWork, IMapper mapper)
		{
            _unitOfWork = unitOfWork;
            _mapper = mapper;
		}

        public CommunicationTypeDto GetCommunicationTypeById(int id)
        {
            return _mapper.Map<CommunicationTypeDto>(_unitOfWork.CommunicationTypes.GetById(id));
                
        }

        public CommunicationTypeDto GetCommunicationTypeByLabel(string label)
        {
            Expression<Func<CommunicationType, bool>> predicate = c => c.Label == label;
            return _unitOfWork.CommunicationTypes
                .Find(predicate)
                .Select(_mapper.Map<CommunicationTypeDto>)
                .First();
        }

        public IEnumerable<CommunicationTypeDto> GetCommunicationTypes()
        {
            var listCommunicationTypes = _unitOfWork.CommunicationTypes.GetAll();
            return listCommunicationTypes
                .Select(_mapper.Map<CommunicationTypeDto>)
                .ToList();
        }

        public bool AddCommunicationType(CommunicationTypeDto communicationTypeDto)
        {
            var communicationType = _mapper.Map<CommunicationType>(communicationTypeDto);
            _unitOfWork.CommunicationTypes.Add(communicationType);
            _unitOfWork.Complete();
            return true;
        }

        public bool DeleteCommunicationTypeService(int id)
        {
            var communicationType = _unitOfWork.CommunicationTypes.GetById(id);
            if(communicationType != null)
            {
                _unitOfWork.CommunicationTypes.Remove(communicationType);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }

        public bool UpdateCommunicationType(CommunicationTypeDto communicationTypeDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCommunicationType(int id)
        {
            throw new NotImplementedException();
        }
    }
}

