namespace InterfacesDemo;

internal interface IDrivable
{
    int Wheels { get; set; }
    double Speed { get; set; }
    
    void Move();
    void Stop();
}