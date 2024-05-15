using AspNetCore;
using EStore_frontend.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EStore_frontend.Controllers
{
    public class CouponsController : Controller
    {
        public IActionResult Index()
        {
            var dummyCoupons = new List<CouponsDTO>
            {
                new CouponsDTO {CouponID = 1, CouponName = "Coupon1", CouponDescription = "Description1", CouponPrice = 50, MinAmount = 249},
                new CouponsDTO {CouponID = 2, CouponName = "Coupon2", CouponDescription = "Description2", CouponPrice = 100, MinAmount = 399},
                new CouponsDTO {CouponID = 3, CouponName = "Coupon3", CouponDescription = "Description3", CouponPrice = 150, MinAmount = 599},
            };
            return View(dummyCoupons);
        }
    }
}
