using System.Collections;

namespace GitGud.Analyzers.Tests.Dates.Generators;

public class UtcNowUsageCaseGenerator : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            """
            using System;

            public class Bad
            {
              public DateTime Method()
              {
                return DateTime.UtcNow;
              }
            }
            """,
            7,
            12,
            7,
            27
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}