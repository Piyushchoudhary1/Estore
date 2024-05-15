namespace EStore_frontend.DTO
{
    public class CouponsDTO
    {
        public int CouponID { get; set; }
        public string CouponName { get; set; }
        public string CouponDescription { get; set; }
        public decimal CouponPrice { get; set; }
        public decimal MinAmount { get; set; }
    }
}
