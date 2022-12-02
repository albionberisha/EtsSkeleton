using Ets.Data.UnitOfWork;
using Ets.Services.IService;
using AutoMapper;

namespace Ets.Services
{
    public class ExamService : IExamService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ExamService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
