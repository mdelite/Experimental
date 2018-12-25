using Xunit;
using CSVService;

namespace CSVService.UnitTests
{
    public class StringTests
    {
        [Fact]
        public void Empty_CSVSevice_Returns_Empty_String()
        {
            var csv = new CSVService();

            Assert.Equal(csv.ToString(),string.Empty);
        }
    }
}