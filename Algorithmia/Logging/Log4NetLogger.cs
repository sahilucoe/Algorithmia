using log4net;

namespace Algorithmia.Logging
{
    /// <summary>
    /// Implementation of ILogger using log4net logging library.
    /// </summary>
    public class Log4NetLogger : ILogger
    {
        private readonly ILog _logger;

        /// <summary>
        /// Initializes a new instance of the Log4NetLogger class.
        /// </summary>
        public Log4NetLogger()
        {
            // Initialize the logger using log4net
            _logger = LogManager.GetLogger(typeof(Log4NetLogger));
        }

        /// <inheritdoc/>
        public void LogInformation(string message)
        {
            // Log informational message
            _logger.Info(message);
        }

        /// <inheritdoc/>
        public void LogWarning(string message)
        {
            // Log warning message
            _logger.Warn(message);
        }

        /// <inheritdoc/>
        public void LogError(string message)
        {
            // Log error message
            _logger.Error(message);
        }

        /// <inheritdoc/>
        public void LogException(Exception exception, string message = null)
        {
            // Log exception along with an optional message
            if (message != null)
            {
                _logger.Error(message, exception);
            }
            else
            {
                _logger.Error(exception);
            }
        }
    }
}
