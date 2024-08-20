using AutoMapper;
using Azure.Core;
using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Request;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Abstraction.UnitOfWork;
using ProdQ.Domain.Shared;
using ProdQ.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.UserCQ.Commands
{
    public sealed record CreateUserCammand(UserDTORequest reqParams) : ICommand<Response<UserDTOResponse>>;

    internal sealed class CreateUserCammandHandler : ICommandHander<CreateUserCammand, Response<UserDTOResponse>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public CreateUserCammandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Response<UserDTOResponse>> Handle(CreateUserCammand request, CancellationToken cancellationToken)
        {
            var response = new Response<UserDTOResponse>();            
            try
            {
                var model = _mapper.Map<User>(request.reqParams);
                var dt = await _unitOfWork.UserRepository.AddAsync(model);
                if(dt!= null)
                {
                    response.Success = true;
                    response.Message = "Successfully added.";
                    response.Data = _mapper.Map<UserDTOResponse>(dt);
                }
                else
                {
                    response.Success = false;
                    response.Message = "Unsuccessful.";
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
