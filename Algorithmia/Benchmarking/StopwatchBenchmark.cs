using Algorithmia.Logging;
using System.Diagnostics;

namespace Algorithmia.Benchmarking
{
    /// <summary>
    /// Provides functionality to measure the execution time of code blocks using Stopwatch.
    /// Stopwatch is used for high-precision timing and accurate measurement of elapsed time.
    /// It offers convenient methods for starting, stopping, and measuring time intervals,
    /// making it suitable for benchmarking and performance analysis tasks.
    /// </summary>
    public class StopwatchBenchmark : IBenchmark
    {
        private readonly Stopwatch _stopwatch;
        private TimeSpan _totalElapsedTime;
        private readonly ILogger _logger;
        private readonly string _name;

        /// <summary>
        /// Initializes a new instance of the StopwatchBenchmark class.
        /// </summary>
        /// <param name="name">Optional name for the benchmark.</param>
        /// <param name="logger">Optional logger instance. If provided, logging will be performed using this logger; otherwise, a default ConsoleLogger will be used.</param>
        public StopwatchBenchmark(string? name = null, ILogger? logger = null)
        {
            _stopwatch = Stopwatch.StartNew();
            _totalElapsedTime = TimeSpan.Zero;
            _logger = logger ?? new ConsoleLogger();
            _name = name ?? string.Empty;
        }

        /// <inheritdoc/>
        public void LogElapsedTime(string message)
        {
            _logger.LogInformation($"{message}: {_stopwatch.Elapsed}");
        }

        /// <inheritdoc/>
        public void LogElapsedTimeAndReset(string message)
        {
            LogElapsedTime(message);
            _totalElapsedTime += _stopwatch.Elapsed;
            _stopwatch.Restart();
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _stopwatch.Stop();
            _totalElapsedTime += _stopwatch.Elapsed;
            _logger.LogInformation($"Total execution time for benchmark '{_name}': {_totalElapsedTime}");
        }
    }
}
