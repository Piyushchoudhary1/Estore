using System;
using System.ComponentModel.DataAnnotations;

public class ProductDto		
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string Image { get; set; }
}

