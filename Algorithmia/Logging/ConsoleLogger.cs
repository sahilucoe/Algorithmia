using System;

namespace Algorithmia.Logging
{
    /// <summary>
    /// Default logger implementation that writes log messages to the console.
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <inheritdoc/>
        public void LogInformation(string message)
        {
            Log("INFO", message);
        }

        /// <inheritdoc/>
        public void LogWarning(string message)
        {
            Log("WARNING", message);
        }

        /// <inheritdoc/>
        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        /// <inheritdoc/>
        public void LogException(Exception exception, string message = null)
        {
            Log("EXCEPTION", message ?? string.Empty);
            Log("EXCEPTION", exception.ToString());
        }

        // Common log method
        private void Log(string level, string message)
        {
            Console.WriteLine($"[{DateTime.Now}] [{level}] {message}");
        }
    }
}
