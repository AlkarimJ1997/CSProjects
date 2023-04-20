namespace Cracker
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var cracker = new Cracker(
                "",
                new[] { "Foo", "Bar" },
                false,
                false,
                false,
                false);
            
            cracker.Run();
        }
    }
}