using NUnit.Framework;
using ConsoleApp23;




namespace LogAnalyzer.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFilename_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("test.l2og");
            Assert.False(result);
        }

        [Test]
        public void IsValidLogFileName_googExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.IsValidLogFileName("test.log");
            Assert.True(result);
        }

    }
}
