using AutoMapper;
using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Abstraction.UnitOfWork;
using ProdQ.Domain.Shared;
using ProdQ.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Queries
{
    public sealed record GetUserByIdQuery(int Id) : IQuery<Response<UserDTOResponse>>;

    internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, Response<UserDTOResponse>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public GetUserByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<Response<UserDTOResponse>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var response = new Response<UserDTOResponse>();
            try
            {
                var dt = await _unitOfWork.UserRepository.GetAsync(request.Id);
                if (dt != null)
                {
                    response.Success = true;
                    response.Message = "Record Found.";
                    response.Data = _mapper.Map<UserDTOResponse>(dt);
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
