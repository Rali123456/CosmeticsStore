using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();

        void AddCategory(Category category);

        Category? GetById(string id);
    }
}

