namespace ODATASamples.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}
