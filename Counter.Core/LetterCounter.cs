using System;
using System.Collections.Generic;
using System.Linq;

namespace Counter.Core
{
    /// <summary>
    /// Represents a letter counter.
    /// </summary>
    public class LetterCounter
    {
        /// <summary>
        /// Counts the letters in a string.
        /// </summary>
        /// <param name="input">The input to count the letters of.</param>
        /// <returns>
        /// An <see cref="IReadOnlyDictionary{TKey,TValue}"/> of <see cref="string"/> and <see cref="int"/>
        /// containing the count results.
        /// </returns>
        public IReadOnlyDictionary<string, int> Count(string input)
        {
            var result = input.Aggregate(new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase), (map, i) =>
            {
                if (map.ContainsKey(i.ToString()))
                {
                    map[i.ToString().ToUpperInvariant()]++;
                }
                else
                {
                    map.Add(i.ToString().ToUpperInvariant(), 1);
                }

                return map;
            });

            return result;
        }
    }
}