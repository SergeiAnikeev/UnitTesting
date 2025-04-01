using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit
{
    [Collection("My Collection Fixture")]
    public class CollectionFixturesBehaviorTests
    {
        private ITestOutputHelper _outputHelper;
        private readonly MyClassFixture _fixture;

        public CollectionFixturesBehaviorTests(ITestOutputHelper outputHelper, MyClassFixture fixture)
        {
            _outputHelper = outputHelper;
            _fixture = fixture;
        }

        [Fact]
        public void Test_Guid_1()
        {
            _outputHelper.WriteLine($"{_fixture.id}");
        }
        [Fact]
        public void Test_Guid_2()
        {
            _outputHelper.WriteLine($"{_fixture.id}");
        }
    }

    [Collection("My Collection Fixture")]
    public class CollectionFixturesBehaviorTestsAgain
    {
        private ITestOutputHelper _outputHelper;
        private readonly MyClassFixture _fixture;

        public CollectionFixturesBehaviorTestsAgain(ITestOutputHelper outputHelper, MyClassFixture fixture)
        {
            _outputHelper = outputHelper;
            _fixture = fixture;
        }

        [Fact]
        public void Test_Guid_1()
        {
            _outputHelper.WriteLine($"{_fixture.id}");
        }
        [Fact]
        public void Test_Guid_2()
        {
            _outputHelper.WriteLine($"{_fixture.id}");
        }

    }
}
