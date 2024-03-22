using Refit;
using TestNSIProduct.Sdk.Dto;

namespace TestNSIProduct.Sdk;

public interface ITestApi
{
    [Post("/api/v1/Product/CreateProduct")]
    public Task<TestProductCreateResponseDto> CreateProductAsync(TestProductRequestDto product);
}