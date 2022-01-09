using System.Collections.Generic;
using Xunit;

namespace Exercises.Level1.Tests.Dictionary1Tests
{
    public class DictionaryShareTests
    {
        private readonly Dictionary1 _dictionary1 = new();

        [Fact]
        public void Test1()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "aaa"},{"b", "bbb"},{"c", "ccc"}
            };

            var response = _dictionary1.DictionaryShare(example);

            var expected = new Dictionary<string, string>
            {
                {"a", "aaa"},{"b", "aaa"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test2()
        {
            var example = new Dictionary<string, string>
            {
                {"b", "xyz"},{"c", "ccc"}
            };

            var response = _dictionary1.DictionaryShare(example);

            var expected = new Dictionary<string, string>
            {
                {"b", "xyz"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test3()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "aaa"},{"c", "meh"},{"d", "hi"}
            };

            var response = _dictionary1.DictionaryShare(example);

            var expected = new Dictionary<string, string>
            {
                {"a", "aaa"},{"b", "aaa"},{"d", "hi"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test4()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "xyz"},{"b", "1234"},{"c", "yo"},{"z", "zzz"}
            };

            var response = _dictionary1.DictionaryShare(example);

            var expected = new Dictionary<string, string>
            {
                {"a", "xyz"},{"b", "xyz"},{"z", "zzz"}
            };

            Assert.Equal(expected, response);
        }

        [Fact]
        public void Test5()
        {
            var example = new Dictionary<string, string>
            {
                {"a", "xyz"},{"b", "1234"},{"c", "yo"},{"d", "ddd"},{"e", "everything"}
            };

            var response = _dictionary1.DictionaryShare(example);

            var expected = new Dictionary<string, string>
            {
                {"a", "xyz"},{"b", "xyz"},{"d", "ddd"},{"e", "everything"}
            };

            Assert.Equal(expected, response);
        }
    }
}
