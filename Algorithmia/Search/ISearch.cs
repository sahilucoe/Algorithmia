namespace Algorithmia.Search
{
    public interface ISearch<T>
    {
        int Search(IEnumerable<T> collection, T target);
    }
}
