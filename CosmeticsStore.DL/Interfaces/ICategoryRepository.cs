using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.DL.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        List<Category> GetAllCategories();
        Category? GetCategoryById(string id);
        void UpdateCategory(Category category);
        void DeleteCategory(string id);
    }
}

