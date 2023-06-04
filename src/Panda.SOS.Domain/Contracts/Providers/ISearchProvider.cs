namespace Panda.SOS.Domain.Contracts.Providers;
public interface ISearchProvider<TIndex>
{
    Task<IEnumerable<TIndex>> SearchAsync(string ticker);
}
