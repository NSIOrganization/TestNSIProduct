using TestNSIProduct.Application.Models;
using TestNSIProduct.Sdk.Dto;

namespace TestNSIProduct.Application.Extensions;

public static class TestResponseExtensions
{
    public static TestProductCreateResponseModel ToModel(this TestProductCreateResponseDto dto)
    {
       return new TestProductCreateResponseModel(dto.Name, dto.Description, dto.CompanyName, dto.CompanyDescription);
    }
}