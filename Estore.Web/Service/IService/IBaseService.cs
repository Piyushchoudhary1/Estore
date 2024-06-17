using EStore.Web.Models;
//using EStore.Web.Models.Dto;

namespace EStore.Web.Service.IService
{
    public interface IBaseService : IDisposable
    {

        Task<ResponseDto?> SendAsync(RequestDto apiRequest);
    }
}
