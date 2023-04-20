namespace InterfacesDemo
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Vehicle buick = new Vehicle() { Brand = "Buick", Wheels = 4, Speed = 160 };

            if (buick is IDrivable isDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can't be driven.");
            }
        }
    }
}