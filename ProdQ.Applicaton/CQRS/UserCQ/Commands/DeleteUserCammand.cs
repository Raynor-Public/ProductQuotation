using AutoMapper;
using ProdQ.Applicaton.Abstraction;
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
    public sealed record DeleteUserCammand(int Id) : ICommand<Response<string>>;

    internal sealed class DeleteUserCammandHandler : ICommandHander<DeleteUserCammand, Response<string>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public DeleteUserCammandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;   
        }
        public async Task<Response<string>> Handle(DeleteUserCammand request, CancellationToken cancellationToken)
        {
            var response = new Response<string>();
            var dt = await _unitOfWork.UserRepository.GetAsync(request.Id);            
            try
            {
                if (dt != null)
                {
                    var model = _mapper.Map<User>(dt);                    
                    var dtRemoved = await _unitOfWork.UserRepository.DeleteAsync(model);
                    if(dtRemoved != null)
                    {
                        response.Success = true;
                        response.Message = "Deleted Successfully.";
                    }
                    else
                    {
                        response.Success = false;
                        response.Message = "Deletion unsuccessful.";
                    }                    
                }
                else
                {
                    response.Success = false;
                    response.Message = "Deletion unsuccessful.";
                }
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Deletion unsuccessful.";
            }

            return response;
        }
    }
}
