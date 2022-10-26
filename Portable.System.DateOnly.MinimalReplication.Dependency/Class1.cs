using System;

namespace MinimalReplication.Dependency
{
    public class Class1
    {
        public static DateOnly Today => DateOnly.FromDateTime(DateTime.Now);
    }
}
