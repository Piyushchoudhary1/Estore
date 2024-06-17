using EStore.Web.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Web.Controllers
{
    public class CouponsController : Controller
    {
        public IActionResult AllCoupons()
        {
            var dummyCoupons = new List<CouponsDTO>
            {
                new CouponsDTO {CouponID = 1, Name = "Coupon1", Description = "Description1", Price = 50, MinAmount = 249},
                new CouponsDTO {CouponID = 2, Name = "Coupon2", Description = "Description2", Price = 100, MinAmount = 399},
                new CouponsDTO {CouponID = 3, Name = "Coupon3", Description = "Description3", Price = 150, MinAmount = 599},
            };


         
            return View(dummyCoupons);
        }
    }
}
