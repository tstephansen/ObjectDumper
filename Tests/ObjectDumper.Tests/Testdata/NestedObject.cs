namespace ObjectDumping.Tests.Testdata
{
    public class NestedObject
    {
        public string Category { get; set; }
        public NestedChild Child { get; set; }
    }

    public class NestedChild
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public SecondNestedChild Child { get; set; }
    }

    public class SecondNestedChild
    {
        public int Age { get; set; }
        [ExcludeFromObjectDumper]
        public string Nickname { get; set; }
    }
}
