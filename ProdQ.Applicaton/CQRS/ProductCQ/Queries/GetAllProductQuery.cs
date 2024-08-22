using AutoMapper;
using ProdQ.Applicaton.Abstraction;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Domain.Abstraction.UnitOfWork;
using ProdQ.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdQ.Applicaton.CQRS.ProductCQ.Queries
{
    public sealed record GetAllProductQuery : IQuery<Response<List<ProductDTOResponse>>>;

    internal sealed class GetAllProductQueryHandler : IQueryHandler<GetAllProductQuery, Response<List<ProductDTOResponse>>>
    {
        IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public GetAllProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<Response<List<ProductDTOResponse>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var response = new Response<List<ProductDTOResponse>>();
            try
            {
                var dt = await _unitOfWork.ProductRepository.GetAllAsync();
                if (dt != null)
                {
                    response.Success = true;
                    response.Message = "Record Found.";
                    response.Data = _mapper.Map<List<ProductDTOResponse>>(dt);
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
