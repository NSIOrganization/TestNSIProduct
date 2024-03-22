using Refit;
using TestNSIProduct.Application.Extensions;
using TestNSIProduct.Application.Models;
using TestNSIProduct.Sdk;

namespace TestNSIProduct.Application.Client;

public class NsiTestSdkClient : INsiTestSdkClient
{
    public async Task<TestProductCreateResponseModel> CreateProductAsync(TestProductRequestModel request)
    {
        var api = RestService.For<ITestApi>(request.BaseUrl);
        var result = await api.CreateProductAsync(request.ToDto());
        return result.ToModel();
    }
}