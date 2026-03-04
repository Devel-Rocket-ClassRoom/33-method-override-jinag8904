using System;

Product[] products =
{
    new Electronics { Name = "노트북", Price = 1500000, Warranty = 24 },
    new Clothing { Name = "청바지", Price = 89000, Size = 'M' },
    new Food { Name = "우유", Price = 3500, ExpirationDate = "2026-06-15" }
};

foreach (var product in products)
{
    Console.WriteLine(product);
    product.GetDescription();
}