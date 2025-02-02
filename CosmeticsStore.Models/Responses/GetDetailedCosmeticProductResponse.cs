using CosmeticsStore.Models.DTO;

namespace CosmeticsStore.Models.Responses
{
    public class GetDetailedCosmeticProductResponse
    {
        public CosmeticProduct CosmeticProduct { get; set; }

        public List<string> Ingredients { get; set; }
    }
}

