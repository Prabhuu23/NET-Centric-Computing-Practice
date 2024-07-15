namespace urlattributeRouting.Areas.Sales.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Changed from int to decimal for Price
    }
}
