
namespace CalculatorLibrary.Tests.Unit
{
    public class MyClassFixture : IDisposable
    {
        public Guid id { get; } = Guid.NewGuid();

        public void Dispose()
        {
            
        }
    }
}
