using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleTables;

namespace Counter.Core
{
    /// <summary>
    /// Represents a results writer.
    /// </summary>
    public class ResultWriter
    {
        private readonly ConsoleTable _table;

        /// <summary>
        /// Initializer a new instance of <see cref="ResultWriter"/>.
        /// </summary>
        /// <param name="table">The table to write to.</param>
        public ResultWriter(ConsoleTable table)
        { 
            _table = table;
        }

        /// <summary>
        /// Writes the results of a count to the console in tabular form.
        /// </summary>
        /// <param name="results">The count results to write</param>
        public void Write(IReadOnlyDictionary<string, int> results)
        {
            _table.AddColumn(results.Keys);
            _table.AddRow(results.Values.Cast<object>().ToArray());
            _table.Write();
        }
    }
}