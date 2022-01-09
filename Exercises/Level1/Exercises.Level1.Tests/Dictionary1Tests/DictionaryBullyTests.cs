using System.Collections.Generic;
using Xunit;

namespace Exercises.Level1.Dictionary1Tests.Tests
{
    public class DictionaryBullyTests
    {
        private readonly Dictionary1 _dictionary1 = new();

        [Fact]
        public void Test1()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "candy"},{"b", "dirt"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"a", ""},{"b", "candy"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test2()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "candy"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"a", ""},{"b", "candy"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test3()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "candy"},{"b", "carrot"},{"c", "meh"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"a", ""},{"b", "candy"},{"c", "meh"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test4()
        {
            var example = new Dictionary<string, string>
            {
                {"b", "carrot"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"b", "carrot"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test5()
        {
            var example = new Dictionary<string, string>
            {
                {"c", "meh"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"c", "meh"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test6()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "sparkle"},{"c", "meh"}
            };

            var response = _dictionary1.DictionaryBully(example);

            var expected = new Dictionary<string, string>
            {
                {"a", ""},{"b", "sparkle"},{"c", "meh"}
            };

            Assert.Equal(expected, response);
        }
    }
}
