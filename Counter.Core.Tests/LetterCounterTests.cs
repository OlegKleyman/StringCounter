using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Counter.Core.Tests
{
    public class LetterCounterTests
    {
        [Fact]
        public void CountShouldReturnTheNumberLettersAppearsInTheString()
        {
            var counter = new LetterCounter();
            counter.Count("test").Should().BeEquivalentTo(new Dictionary<string, int>
            {
                ["T"] = 2,
                ["E"] = 1,
                ["S"] = 1
            });
        }

        [Fact]
        public void CountShouldReturnTheNumberLettersAppearsInTheStringRegardlessOfCase()
        {
            var counter = new LetterCounter();
            counter.Count("tesT").Should().BeEquivalentTo(new Dictionary<string, int>
            {
                ["T"] = 2,
                ["E"] = 1,
                ["S"] = 1
            });
        }
    }
}
