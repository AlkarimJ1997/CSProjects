namespace OOPComplex
{
    public static class Program
    {
        public static void Main()
        {
            IElectronicDevice tv = TvRemote.GetDevice();
            PowerButton powerButton = new PowerButton(tv);
            
            powerButton.Execute();
            powerButton.Undo();
            powerButton.Execute();
            powerButton.Undo();
        }
    }
}