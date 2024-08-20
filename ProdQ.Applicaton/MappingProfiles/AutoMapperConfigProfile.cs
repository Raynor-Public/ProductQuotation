using AutoMapper;
using Azure.Identity;
using ProdQ.Applicaton.DTO.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProdQ.Domain.Entities;
using ProdQ.Applicaton.DTO.Response;
using ProdQ.Infrastructure;

namespace ProdQ.Applicaton.MappingProfiles
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile() {

            // Map Client to ClientDTOResponse
            CreateMap<Client, ClientDTOResponse>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Street + ", " + src.State + ", " + src.City + ", " + src.Country));
            // Map List<Client> to Response<ClientDTOResponse>
            //CreateMap<List<Client>, List<ClientDTOResponse>>()
            //    .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.LastName))
            //    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Street + ", " + src.State + ", " + src.City + ", " + src.Country));

            //Users
            CreateMap<User, UserDTOResponse>()
                .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => $"Summary : Created by {src.Createdby} on {src.Createddate}"));

            CreateMap<UserDTORequest, User>()
                .ForMember(dest => dest.Fullname, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Createddate, opt => opt.MapFrom(src => DateOnly.FromDateTime(DateTime.Now)))
                .ForMember(dest => dest.Createdby, opt => opt.MapFrom(src => 1)); //temp set to 1 as admin
            


            //Products



            //Qoute



            //QouteItmes


        }

        private static DateTime GetNow()
        {
            return DateTime.Now;
        }

    }
}
