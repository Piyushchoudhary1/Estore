namespace Estore.Web.DTO
    {
    public class CouponsDTO
    {
        public int CouponID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal MinAmount { get; set; }
    }
}
