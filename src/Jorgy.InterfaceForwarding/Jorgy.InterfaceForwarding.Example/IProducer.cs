namespace Jorgy.InterfaceForwarding.Example;

public interface IProducer
{
    void Produce(int count);

    int TotalProduced { get; }
}