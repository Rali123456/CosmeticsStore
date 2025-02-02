using Mapster;
using CosmeticsStore.Models.DTO;
using CosmeticsStore.Models.Requests;

namespace CosmeticsStore.MapsterConfig
{
    public class MapsterConfiguration
    {
        public static void Configure()
        {
            TypeAdapterConfig<CosmeticsProduct, AddProductRequest>
                .NewConfig()
                .TwoWays();

           
            TypeAdapterConfig<UpdateProductRequest, CosmeticsProduct>
                .NewConfig()
                .TwoWays();
        }
    }
}

