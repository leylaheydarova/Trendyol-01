namespace Trendyol.Services.Interfaces
{
    public interface IService<TCreateDto, TGetDto>
    {
        string Create(TCreateDto dto);
        string Delete(int categoryId);
        List<TGetDto> GetAll();
        TGetDto GetSingle(int categoryId);
    }
}
