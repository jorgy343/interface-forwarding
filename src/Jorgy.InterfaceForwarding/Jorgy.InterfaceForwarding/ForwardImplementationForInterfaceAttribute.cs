using System;

namespace Jorgy.InterfaceForwarding;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
public class ForwardImplementationForInterfaceAttribute : Attribute
{
    public ForwardImplementationForInterfaceAttribute(Type interfaceType)
    {
        InterfaceType = interfaceType;
    }

    public Type InterfaceType { get; }
}