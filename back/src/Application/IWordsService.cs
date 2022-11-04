using Domain.Entities;

namespace Application;

public interface IWordsService
{
    Task<IEnumerable<Word>> GetWordsAsync();
}
