using Estore.Web.Models;
using Estore.Web.Models.Dto;

namespace Estore.Web.Service.IService
{
    public interface IBaseService : IDisposable
    {

        Task<ResponseDto?> SendAsync(RequestDto apiRequest);
    }
}
