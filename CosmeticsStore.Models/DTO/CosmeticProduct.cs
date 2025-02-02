namespace CosmeticsStore.Models.DTO
{
    public class CosmeticProduct
    {
        public string ProductId { get; set; }  // Уникален идентификатор на продукта

        public string ProductName { get; set; } = string.Empty;  // Името на козметичния продукт

        public string Brand { get; set; } = string.Empty;  // Бранд на продукта

        public string Category { get; set; } = string.Empty;  // Категория на продукта (например: грим, грижа за кожата и т.н.)

        public decimal Price { get; set; }  // Цена на продукта

        public List<string> Ingredients { get; set; }  // Списък със съставки на продукта
    }
}
}

