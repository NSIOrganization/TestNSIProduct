using TestNSIProduct.Sdk.Dto;

namespace TestNSIProduct.Application.Models;

public record TestProductRequestModel(Guid CompanyId, string Name, string BaseUrl)

{
    public TestProductRequestDto ToDto()
    {
        return new TestProductRequestDto(new TestProductCreateDto(CompanyId, Name, Name + " - " + CompanyId));
    }
}