using System;

namespace NServiceBus.AttributeConventions.Contracts
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    public sealed class EventAttribute : Attribute
    {

    }
}
