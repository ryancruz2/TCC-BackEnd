namespace Panda.SOS.Services.Search;
public class SearchProvider<TIndex> : ISearchProvider<TIndex>
    where TIndex : class
{
    private readonly SearchClient _searchService;
    private readonly IConfiguration _configuration;

    public SearchProvider(SearchClient _searchService, IConfiguration configuration)
    {
        this._searchService = _searchService;
        _configuration = configuration;
    }

    public async Task<IEnumerable<TIndex>> SearchAsync(string search)
    {
        try
        {
            var options = new SearchOptions()
            {
                QueryType = SearchQueryType.Full,
                Size = string.IsNullOrEmpty(search)? 10 : 5,

            };

            SearchResults<TIndex>? response = await _searchService.SearchAsync<TIndex>(string.IsNullOrEmpty(search)? "": $"{search}~2", options);
            var result = response.GetResults().ToList().Select(doc => doc.Document);
            return result;
        }
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }

    }
}