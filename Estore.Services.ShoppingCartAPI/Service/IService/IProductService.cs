using Estore.ShoppingCartAPI.Models.Dto;

namespace EStore.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
