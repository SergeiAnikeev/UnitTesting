namespace CalculatorLibrary.Tests.Unit
{
    public class LomgRunningTests
    {
        [Fact(Timeout = 2000)]
        public async Task SlowTest()
        {
            await Task.Delay(10000);
        }
    }
}
