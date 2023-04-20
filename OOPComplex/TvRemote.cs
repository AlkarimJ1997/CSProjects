namespace OOPComplex;

internal class TvRemote
{
    public static IElectronicDevice GetDevice()
    {
        return new Television();
    }
}