

namespace CosmeticsStore.Models.Request
{
	public class UpdateProductRequest
	{
        public int Id { get; set; }  // Идентификатор на продукта

        public string Name { get; set; }  // Име на продукта

        public string Description { get; set; }  // Описание на продукта

        public decimal Price { get; set; }  // Цена на продукта

        public string Category { get; set; }  // Категория на продукта

        public List<string> Ingredients { get; set; }  // Съставки на продукта
    }
}
