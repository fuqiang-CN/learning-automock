using Autofac.Extras.Moq;
using learning_automock;
using Xunit;

namespace learning_automock_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Provide<IDependency, FakeDependency>();

                var sut = mock.Create<SystemUnderTest>();
                var result = sut.DoWork();
                Assert.Equal("Hello, World", result);
            }
        }
    }
}
