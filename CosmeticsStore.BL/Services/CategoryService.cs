using CosmeticsStore.BL.Interfaces;
using CosmeticsStore.DL.Interfaces;
using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.BL.Services
{
    internal class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category? GetById(string id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}

