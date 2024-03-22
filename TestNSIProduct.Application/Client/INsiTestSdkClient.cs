using TestNSIProduct.Application.Models;

namespace TestNSIProduct.Application.Client;

public interface INsiTestSdkClient
{
    public Task<TestProductCreateResponseModel> CreateProductAsync(TestProductRequestModel request);
}