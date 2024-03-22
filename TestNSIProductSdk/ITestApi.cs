using Refit;
using TestNSIProductSdk.Dto;

namespace TestNSIProductSdk;

public interface ITestApi
{
    [Post("/api/v1/Product/CreateProduct")]
    public Task<TestProductCreateResponseDto> CreateProductAsync(TestProductRequestDto product);
}