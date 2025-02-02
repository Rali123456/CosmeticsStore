namespace CosmeticsStore.Models.Requests
{
    public class AddProductRequest
    {
        public string Name { get; set; }  // Име на продукта

        public string Description { get; set; }  // Описание на продукта

        public decimal Price { get; set; }  // Цена на продукта

        public string Category { get; set; }  // Категория на продукта (например "Лице", "Коса", "Тяло")

        public List<string> Ingredients { get; set; }  // Съставки на продукта
    }
}

