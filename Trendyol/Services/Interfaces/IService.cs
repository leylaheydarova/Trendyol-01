namespace Trendyol.Services.Interfaces
{
    public interface IService<TCreateDto, TGetDto>
    {
        string Create(TCreateDto dto);
        string Delete(int id);
        List<TGetDto> GetAll();
        TGetDto GetSingle(int id);
    }
}
