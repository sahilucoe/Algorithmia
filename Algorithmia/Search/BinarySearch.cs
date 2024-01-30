
namespace Algorithmia.Search
{
    public class BinarySearch<T> : ISearch<T> where T : IComparable<T>
    {
        /// <summary>
        /// Searches for an element in a sorted collection using Binary Search
        /// </summary>
        /// <param name="collection">Sorted collection</param>
        /// <param name="target">Target element</param>
        /// <returns>Index of the element is returned if it is found in the collection, else -1 is returned.</returns>
        /// <exception cref="ArgumentNullException">Throws ArgumentNullException if collection is null.</exception>
        public int Search(IEnumerable<T> collection, T target)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            List<T> sortedList = new(collection);

            int left = 0;
            int right = sortedList.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int comparisonResult = target.CompareTo(sortedList[mid]);

                if (comparisonResult == 0)
                {
                    return mid; // Element found
                }
                else if (comparisonResult < 0)
                {
                    right = mid - 1; // Target is in the left half
                }
                else
                {
                    left = mid + 1; // Target is in the right half
                }
            }

            return -1; // Element not found
        }
    }
}
