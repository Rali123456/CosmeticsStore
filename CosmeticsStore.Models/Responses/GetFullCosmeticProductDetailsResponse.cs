using CosmeticsStore.Models.Views;

namespace CosmeticsStore.Models.Responses
{
    public class GetFullCosmeticProductDetailsResponse
    {
        public IEnumerable<CosmeticProductView> Products { get; set; } = new List<CosmeticProductView>();
    }
}


