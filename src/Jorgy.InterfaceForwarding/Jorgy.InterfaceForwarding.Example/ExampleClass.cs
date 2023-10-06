namespace Jorgy.InterfaceForwarding.Example;

public partial class ExampleClass
{
    [ForwardImplementationForInterface(typeof(IProducer))]
    private readonly Producer _producer;

    public ExampleClass(Producer producer)
    {
        _producer = producer ?? throw new ArgumentNullException(nameof(producer));
    }
}