using Trendyol.DTOs.ProductShop;
using Trendyol.Services.Implements;
using Trendyol.Services.Interfaces;

IProductShopService _service = new ProductShopService();
var dto1 = new ProductShopCreateDto
{
    ProductId = 1,
    ShopId = 2
};

var dto2 = new ProductShopCreateDto
{
    ProductId = 3,
    ShopId = 2
};

var dto3 = new ProductShopCreateDto
{
    ProductId = 1,
    ShopId = 3
};

var dto4 = new ProductShopCreateDto
{
    ProductId = 8,
    ShopId = 4
};

var dto5 = new ProductShopCreateDto
{
    ProductId = 3,
    ShopId = 2
};
_service.Create(dto1);
_service.Create(dto2);
_service.Create(dto3);
_service.Create(dto4);
_service.Create(dto5);

var item = _service.GetSingle(6);
Console.WriteLine($"Id: {item.Id}, ProductId: {item.ProductId}, ShopId: {item.ShopId}");
