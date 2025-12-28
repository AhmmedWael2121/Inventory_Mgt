using AutoMapper;
using Inventory.Domains.Entities.ProductEntity;
using Inventory.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Persistence.Mapping
{
    public class ProductMapp : Profile
    {
        public ProductMapp()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(
                dest => dest.Code, opt => opt.MapFrom(src => src.ProductCode)
                ).ForMember(
                dest => dest.Name, opt => opt.MapFrom(src => src.Name)
                ).ForMember(
                dest => dest.Description, opt => opt.MapFrom(src => src.Description)
                ).ForMember(
                dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity)
                ).ForMember(
                dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice)
                )
                .ForMember(
                dest => dest.CategoryCode, opt => opt.MapFrom(src => src.CategoryCode)
                )
                .ReverseMap();

            CreateMap<CreateProductDto, Product>().ForMember(
                dest => dest.ProductCode, opt => opt.MapFrom(src => src.ProductCode)
                ).ForMember(
                dest => dest.Name, opt => opt.MapFrom(src => src.Name)
                ).ForMember(
                dest => dest.Description, opt => opt.MapFrom(src => src.Description)
                ).ForMember(
                dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity)
                ).ForMember(
                dest => dest.UnitPrice, opt => opt.MapFrom(src => src.UnitPrice)
                ).ForMember(
                dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId)
                )
                .ReverseMap();
            // CreateMap<Source, Destination>();
        }
    }
}
