using AutoMapper;
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
    public sealed record UpdateUserCammand(int Id, UserDTORequest reqParams) : ICommand<Response<UserDTOResponse>>;

    internal sealed class UpdateUserCammandHandler : ICommandHander<UpdateUserCammand, Response<UserDTOResponse>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public UpdateUserCammandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Response<UserDTOResponse>> Handle(UpdateUserCammand request, CancellationToken cancellationToken)
        {
            var response = new Response<UserDTOResponse>();
            try
            {
                var getDt = await _unitOfWork.UserRepository.GetAsync(request.Id);
                if (getDt != null)
                {
                    var model = _mapper.Map<User>(getDt);
                    var updateDt = await _unitOfWork.UserRepository.Update(model);
                    if(updateDt != null)
                    {
                        response.Success = true;
                        response.Message = "Record updated successfully.";
                        response.Data = _mapper.Map<UserDTOResponse>(updateDt);
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Failed to update record.";
                    }                    
                }
                else
                {
                    response.Success = false;
                    response.Message = "Record not found.";
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
