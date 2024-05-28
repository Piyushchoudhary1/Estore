
using EStore.Services.OrdersAPI.Models.Dto;

namespace EStore.Services.ProductAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
