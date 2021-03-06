using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Ray.BiliBiliTool.Console;
using Ray.BiliBiliTool.Infrastructure;
using Xunit;

namespace LogTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program.PreWorks(new string[] { });

            var logger = RayContainer.Root.GetRequiredService<ILogger<UnitTest1>>();

            logger.LogInformation("testInfo");
            logger.LogDebug("testDebug");
            logger.LogError("testError");

            Task.Delay(3000);
        }
    }
}
