namespace ECommerceApi2.Models
{
    namespace ECommerceAPI.Models
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            // 👇 This is the flag
            public bool IsAvailable { get; set; }
        }
    }

}
