﻿using System;

public class ProductDto		
{
    [Required]
    public string Name { get; set; } = "";
    [Required]
    public string Description { get; set; } = "";
    [Required]
    public decimal Price { get; set; } = "";
    [Required]
    public string Image { get; set; } = "";
}
}
