namespace Jorgy.InterfaceForwarding.Example;

public class Producer : IProducer
{
    private int _totalProduced;

    public void Produce(int count)
    {
        Interlocked.Add(ref _totalProduced, count);
    }

    public int TotalProduced => _totalProduced;
}