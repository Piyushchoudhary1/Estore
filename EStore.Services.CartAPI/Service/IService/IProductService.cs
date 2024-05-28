using Estore.CartAPI.Models.Dto;

namespace EStore.Services.CartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
