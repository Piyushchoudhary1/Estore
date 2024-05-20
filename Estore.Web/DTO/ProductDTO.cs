namespace Estore.Web.DTO
{ 
    public class ProductDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
       // public required string ImageURL { get; set; }
    }
}
