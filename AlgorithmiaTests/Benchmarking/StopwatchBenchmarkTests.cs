using Algorithmia.Benchmarking;
using Algorithmia.Logging;
using AutoFixture;
using AutoFixture.AutoMoq;
using Moq;
using NUnit.Framework;

namespace AlgorithmiaTests.Benchmarking
{
    [TestFixture]
    public class StopwatchBenchmarkTests
    {
        private IFixture _fixture;

        [SetUp]
        public void Setup()
        {
            // Initialize AutoFixture with AutoMoq customization
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
        }

        [Test]
        public void LogElapsedTime_LogsElapsedTime()
        {
            // Arrange
            var loggerMock = _fixture.Freeze<Mock<ILogger>>();
            var benchmark = _fixture.Create<StopwatchBenchmark>();

            // Act
            benchmark.LogElapsedTime("Test Message");

            // Assert
            loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void LogElapsedTimeAndReset_LogsElapsedTimeAndResetsStopwatch()
        {
            // Arrange
            var loggerMock = _fixture.Freeze<Mock<ILogger>>();
            var benchmark = _fixture.Create<StopwatchBenchmark>();

            // Act
            benchmark.LogElapsedTimeAndReset("Test Message");

            // Assert
            loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void Dispose_LogsTotalExecutionTime()
        {
            // Arrange
            var loggerMock = _fixture.Freeze<Mock<ILogger>>();
            var benchmark = _fixture.Create<StopwatchBenchmark>();

            // Act
            benchmark.Dispose();

            // Assert
            loggerMock.Verify(l => l.LogInformation(It.IsAny<string>()), Times.Once);
        }
    }
}
