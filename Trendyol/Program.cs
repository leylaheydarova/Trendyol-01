using Trendyol.DTOs.Shop;
using Trendyol.Services.Implements;
using Trendyol.Services.Interfaces;

//ICategoryService _categoryService = new CategoryService();
//Console.Write("Category name: ");
//var name = Console.ReadLine();
//Console.Write("Parent category Id: ");
//var parentId = Convert.ToInt32(Console.ReadLine());
//var dto1 = new CategoryCreateDto()
//{
//    Name = "Ushaq"
//};

//var dto2 = new CategoryCreateDto()
//{
//    Name = "Geyim",
//    ParentId = 1
//};

//var dto3 = new CategoryCreateDto()
//{
//    Name = "Ayaqqabi",
//    ParentId = 6
//};

//var dto4 = new CategoryCreateDto()
//{
//    Name = "Paltar"
//};

//var dto5 = new CategoryCreateDto()
//{
//    Name = "Ev eshyalari",
//    ParentId = 4
//};

//var dto6 = new CategoryCreateDto()
//{
//    Name = "Chanta",
//    ParentId = 1
//};

//var dto7 = new CategoryCreateDto()
//{
//    Name = "Kishi",
//    ParentId = 1
//};
//_categoryService.Create(dto1);
//_categoryService.Create(dto2);
//_categoryService.Create(dto3);
//_categoryService.Create(dto4);
//_categoryService.Create(dto5);
//_categoryService.Create(dto6);
//_categoryService.Create(dto7);

//Console.Write("Category Id: ");
//var categoryId = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(_categoryService.Delete(categoryId));

//var updateDto = new CategoryUpdateDto
//{
//    Name = "Ushaq",
//    ParentId = 1
//};

//Console.WriteLine(_categoryService.Update(categoryId, updateDto));
//var dtos = _categoryService.GetAll();
//foreach (var dto in dtos)
//{
//    Console.WriteLine($"Id: {dto.Id}, Name: {dto.Name}, ParentId: {dto.ParentId}");
//}

//var dto = _categoryService.GetSingle(categoryId);
//Console.WriteLine($"Id: {dto.Id}, Name: {dto.Name}, ParentId: {dto.ParentId}");

IShopService _shopService = new ShopService();
var dto = new ShopCreateDto()
{
    Address = "Huseyn Cavid 10",
    Name = "Tofig"
};

Console.WriteLine(_shopService.Create(dto));