using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmia.Benchmarking
{

    /// <summary>
    /// Represents functionality to measure the execution time of code blocks.
    /// </summary>
    public interface IBenchmark : IDisposable
    {
        /// <summary>
        /// Logs the elapsed time since the benchmark started.
        /// </summary>
        /// <param name="message">Message to log along with the elapsed time.</param>
        void LogElapsedTime(string message);

        /// <summary>
        /// Logs the elapsed time since the benchmark started and resets the benchmark.
        /// </summary>
        /// <param name="message">Message to log along with the elapsed time.</param>
        void LogElapsedTimeAndReset(string message);
    }

}
