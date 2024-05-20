using static EStore.Services.CouponAPI.Utility.SD;

namespace EStore.Services.CouponAPI.Models.Dto
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string? Url { get; set; }
        public object? Data { get; set; }
        //public string AccessToken { get; set; }
    }
}