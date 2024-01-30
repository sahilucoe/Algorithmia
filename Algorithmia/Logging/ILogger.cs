namespace Algorithmia.Logging
{
    /// <summary>
    /// Represents a common interface for logging messages and exceptions.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs an informational message.
        /// </summary>
        void LogInformation(string message);

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        void LogWarning(string message);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        void LogError(string message);

        /// <summary>
        /// Logs an exception along with an optional message.
        /// </summary>
        void LogException(Exception exception, string message = null);
    }
}
