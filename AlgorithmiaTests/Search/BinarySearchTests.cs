using Algorithmia.Search;

namespace AlgorithmiaTests.Search
{
    internal class BinarySearchTests
    {
        private ISearch<int> _search;
        private List<int> _collection;

        [SetUp]
        public void Setup()
        {
            _search = new BinarySearch<int>();
            _collection = new List<int>()
            {
                1,5,7,9,12,32,232,2344,2366
            };
        }

        [Test]
        public void ElementPresentTest()
        {
            // Act
            var index = _search.Search(_collection, 2344);

            // Assert
            Assert.That(index, Is.EqualTo(7));
        }

        [Test]
        public void ElementMissingTest()
        {
            // Act
            var index = _search.Search(_collection, 2345);

            // Assert
            Assert.That(index, Is.EqualTo(-1));
        }
    }
}