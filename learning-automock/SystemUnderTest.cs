using System;

namespace learning_automock
{
    public class SystemUnderTest
    {
        private readonly IDependency dependency;

        public SystemUnderTest(IDependency strings)
        {
            this.dependency = strings;
        }

        public string DoWork()
        {
            return this.dependency.GetValue();
        }
    }

    public interface IDependency
    {
        string GetValue();
    }

    public class FakeDependency : IDependency
    {
        public string GetValue()
        {
            return "Hello, World";
        }
    }
}