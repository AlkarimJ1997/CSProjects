namespace OOPComplex;

internal class PowerButton : ICommand
{
    private IElectronicDevice _device;
    
    public PowerButton(IElectronicDevice device)
    {
        _device = device;
    }
    
    public void Execute()
    {
        _device.On();
    }
    
    public void Undo()
    {
        _device.Off();
    }
}