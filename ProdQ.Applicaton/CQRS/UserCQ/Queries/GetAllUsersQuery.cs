using AutoMapper;
using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Shared;
using ProdQ.Domain.Abstraction.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Queries
{
    public sealed record GetAllUsersQuery : IQuery<Response<List<UserDTOResponse>>>;

    internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, Response<List<UserDTOResponse>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Response<List<UserDTOResponse>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {            
            var response = new Response<List<UserDTOResponse>>();
            try
            {
                var dt = await _unitOfWork.UserRepository.GetAllAsync();
                if (dt != null)
                {
                    response.Success = true;
                    response.Message = "Record found successfully";
                    response.Data = _mapper.Map<List<UserDTOResponse>>(dt);
                }
                else
                {
                    response.Success = false;
                    response.Message = "Not Found.";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }            
            return response;
        }
    }
}
