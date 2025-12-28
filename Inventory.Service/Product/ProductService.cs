using AutoMapper;
using Inventory.Domains.Contracts;
using Inventory.Domains.Exceptions.BadRequest;
using Inventory.Domains.Exceptions.NotFound;
using Inventory.Domains.Exceptions.ProductExp;
using Inventory.Service.Abstractions.Product ;
using Inventory.Shared.DTOs.ProductDTOs;

namespace Inventory.Service.Product
{
    public class ProductService(IUnitOfWork _UOW, IProductRepository _ProdRepo, IMapper mapper) : IProductService
    {
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var res = await _ProdRepo.GetAllAsync() ?? throw new ProductNotFoundExp("Can't found any Products !!");

            return mapper.Map<IEnumerable<ProductDto>>(res); 
        }
        public async Task<ProductDto?> GetByIdAsync(string code)
        {
            var product = await _ProdRepo.GetByIdAsync(code) ?? throw new ProductNotFoundExp(code);
            return mapper.Map<ProductDto>(product); 
        }



        public Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            var productEntity = mapper.Map<Domains.Entities.ProductEntity.Product>(dto);
            var createdProduct =  _ProdRepo.AddAsync(productEntity);
            return mapper.Map<Task<ProductDto>>(createdProduct) ?? throw new ProductBadRequestExp("Not Created");
        }

        public Task<IEnumerable<ProductDto>> GetProductsByCategoryIdAsync(string? catCode)
        {
            var GetProducts = _ProdRepo.GetProductsByCategoryIdAsync(catCode);
            return mapper.Map<Task<IEnumerable<ProductDto>>>(GetProducts) ?? throw new CategoryNotFoundExp(catCode);
        }
        public async Task UpdateAsync(ProductDto dto)
        {
            var productEntity = mapper.Map<Domains.Entities.ProductEntity.Product>(dto) ?? throw new ProductBadRequestExp("!Error!");
            _ProdRepo.Update(productEntity);
             await _UOW.SaveChangesAsync();
        }
        public async Task DeleteAsync(string code)
        {
            var productEntity =  _ProdRepo.GetByIdAsync(code) ?? throw new ProductNotFoundExp(code);
             _ProdRepo.Remove(productEntity.Result);
            await _UOW.SaveChangesAsync();
        }

    }
}
