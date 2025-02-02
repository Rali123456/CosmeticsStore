using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.Models.Views

public class CosmeticsView
{
    public string ProductId { get; set; }  // Идентификатор на продукта

    public string ProductName { get; set; } = string.Empty;  // Името на продукта

    public string Brand { get; set; } = string.Empty;  // Бранд на продукта

    public string Category { get; set; } = string.Empty;  // Категория на продукта (например: грим, грижа за кожата и т.н.)

    public decimal Price { get; set; }  // Цена на продукта

    public IEnumerable<string> Ingredients { get; set; } = new List<string>();  // Съставки на продукта

    public string Description { get; set; } = string.Empty;  // Описание на продукта

    public bool IsAvailable { get; set; }  // Наличност на продукта
}
